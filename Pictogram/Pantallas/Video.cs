using Emgu.CV;
using Emgu.CV.Structure;
using Pictogram.Componentes;
using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using System.Linq;
using Emgu.CV.Reg;

namespace Pictogram.Pantallas
{
    public partial class Video : Form
    {
        private VideoCapture _capture;
        private Mat _frame;
        private Timer _videoTimer;
        private bool _isPlaying = false; // Bandera para controlar el estado de reproducción
        private string _currentFilter = "None"; // Filtro actual

        public Video()
        {
            InitializeComponent();
            _frame = new Mat();
            AddFilterPanels();
        }

        private void btn_upload_video_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de video (*.mp4;*.avi;*.mov)|*.mp4;*.avi;*.mov|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Detener y liberar recursos del video anterior si existe
                if (_capture != null)
                {
                    _videoTimer.Stop();
                    _capture.Dispose();
                }

                _capture = new VideoCapture(openFileDialog.FileName);
                if (!_capture.IsOpened)
                {
                    MessageBox.Show("No se pudo abrir el archivo de video.");
                    return;
                }

                _videoTimer = new Timer();
                _videoTimer.Interval = 30;
                _videoTimer.Tick += VideoTimer_Tick;
                _videoTimer.Start();
                _isPlaying = true;

                btn_pause_play.Text = "Pause";
                btn_pause_play.Enabled = true;
            }
        }


        private void VideoTimer_Tick(object sender, EventArgs e)
        {

            if (_frame != null)
            {
                _frame.Dispose(); // Liberar memoria del frame anterior
            }

            // Lee el siguiente cuadro

            _frame = new Mat();
            _capture.Read(_frame);

            if (!_frame.IsEmpty)
            {
                // Aplica el filtro seleccionado
                ApplyFilterToFrame();


                // Redimensiona el cuadro del video para ajustarse al tamaño del PictureBox
                var resizedFrame = _frame.ToImage<Bgr, byte>().Resize(pb_video.Width, pb_video.Height, Emgu.CV.CvEnum.Inter.Linear);
                
                // Convertir el frame a Bitmap
                Bitmap frameBitmap = resizedFrame.ToBitmap();
                ComputeHistogram(frameBitmap);
                // Muestra el cuadro redimensionado en el PictureBox
                pb_video.Image = resizedFrame.ToBitmap();

                // Liberar el buffer de la imagen después de usarlo
                resizedFrame.Dispose();
            }
            else
            {
                // Reinicia el video al principio
                _capture.Set(Emgu.CV.CvEnum.CapProp.PosFrames, 0);
            }
        }


        private void btn_pause_play_Click(object sender, EventArgs e)
        {
            if (_isPlaying)
            {
                _videoTimer.Stop();
                btn_pause_play.Text = "Play";
            }
            else
            {
                _videoTimer.Start();
                btn_pause_play.Text = "Pause";
            }

            _isPlaying = !_isPlaying;
        }

        // Agrega los paneles de filtro
        private void AddFilterPanels()
        {
            string[] filterNames = { "Gris", "Sepia", "Brillo", "Inverso" };

            foreach (string filter in filterNames)
            {
                FilterPanel panel = new FilterPanel
                {
                    FilterName = filter
                };
                panel.FilterClicked += (s, e) => ApplyFilter(((FilterPanel)s).FilterName);
                FlowPanelFilters.Controls.Add(panel);
            }
        }

        // Aplica el filtro según el tipo
        private void ApplyFilter(string filterType)
        {
            _currentFilter = filterType;
        }

        // Aplica el filtro al cuadro del video
        private void ApplyFilterToFrame()
        {
            switch (_currentFilter)
            {
                case "Gris":
                    _frame = _frame.ToImage<Bgr, byte>().Convert<Gray, byte>().Mat; // Escala de grises
                    break;
                case "Sepia":
                    ApplySepiaFilter(); // Filtro sepia
                    break;
                case "Brillo":
                    ApplySepiaFilter(); // Aumenta el brillo
                    break;
                case "Inverso":
                    _frame = _frame.ToImage<Bgr, byte>().Not().Mat; // Inverso de los colores
                    break;
                default:
                    break;
            }
            btn_resetfilter.Enabled = true;
        }


        // Aplica filtro sepia
        private void ApplySepiaFilter()
        {
            // Matriz para el filtro sepia
            Mat sepiaKernel = new Mat(3, 3, DepthType.Cv8U, 1);
            sepiaKernel.SetTo(new byte[] { 112, 66, 20, 70, 130, 95, 15, 33, 100 });
            CvInvoke.Transform(_frame, _frame, sepiaKernel);


        }
        private void ComputeHistogram(Bitmap bitmap)
        {
            int[] histogramR = new int[256];
            int[] histogramG = new int[256];
            int[] histogramB = new int[256];

            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                                                 ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * bitmap.Height;
            byte[] pixelValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            for (int y = 0; y < bitmap.Height; y++)
            {
                int offset = y * stride;
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int index = offset + (x * 3);
                    byte b = pixelValues[index];
                    byte g = pixelValues[index + 1];
                    byte r = pixelValues[index + 2];
                    histogramR[r]++;
                    histogramG[g]++;
                    histogramB[b]++;
                }
            }

            bitmap.UnlockBits(bmpData);
            DrawHistogram(histogramR, pb_histogramaR, Color.Red);
            DrawHistogram(histogramG, pb_histogramaG, Color.Green);
            DrawHistogram(histogramB, pb_histogramaB, Color.Blue);
            DrawCombinedHistogram(histogramR, histogramG, histogramB, pb_histograma);
        }

        private void DrawHistogram(int[] histogram, PictureBox pb_histogram, Color color)
        {
            int width = pb_histogram.Width;
            int height = pb_histogram.Height;
            Bitmap bitmap = new Bitmap(width, height);
            int max = histogram.Max();

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Black);
                for (int x = 0; x < 256; x++)
                {
                    int histHeight = (int)((histogram[x] / (float)max) * (height - 1));
                    g.DrawLine(new Pen(color), x, height, x, height - histHeight);
                }
            }

            pb_histogram.Image = bitmap;
        }

        private void DrawCombinedHistogram(int[] histogramR, int[] histogramG, int[] histogramB, PictureBox pb_histogram)
        {
            int width = pb_histogram.Width;
            int height = pb_histogram.Height;
            Bitmap bitmap = new Bitmap(width, height);
            int maxR = histogramR.Max();
            int maxG = histogramG.Max();
            int maxB = histogramB.Max();
            int max = Math.Max(maxR, Math.Max(maxG, maxB));

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Black);
                for (int x = 0; x < 256; x++)
                {
                    int histHeightR = (int)((histogramR[x] / (float)max) * (height - 1));
                    int histHeightG = (int)((histogramG[x] / (float)max) * (height - 1));
                    int histHeightB = (int)((histogramB[x] / (float)max) * (height - 1));
                    g.DrawLine(new Pen(Color.Red), x, height, x, height - histHeightR);
                    g.DrawLine(new Pen(Color.Green), x, height, x, height - histHeightG);
                    g.DrawLine(new Pen(Color.Blue), x, height, x, height - histHeightB);
                }
            }

            pb_histogram.Image = bitmap;
        }

        private void btn_resetfilter_Click(object sender, EventArgs e)
        {
            _currentFilter = "None";
            btn_resetfilter.Enabled = false;
        }
    }



}
