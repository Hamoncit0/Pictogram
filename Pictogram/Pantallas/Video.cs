using Emgu.CV;
using Emgu.CV.Structure;
using Pictogram.Componentes;
using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.CvEnum;

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
            // Crear un OpenFileDialog para seleccionar el archivo de video
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de video (*.mp4;*.avi;*.mov)|*.mp4;*.avi;*.mov|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Abre el archivo de video seleccionado
                _capture = new VideoCapture(openFileDialog.FileName);

                if (!_capture.IsOpened)
                {
                    MessageBox.Show("No se pudo abrir el archivo de video.");
                    return;
                }

                // Configura el temporizador para leer y mostrar los cuadros del video
                _videoTimer = new Timer();
                _videoTimer.Interval = 30; // 30ms para aproximadamente 30fps
                _videoTimer.Tick += VideoTimer_Tick;
                _videoTimer.Start();

                _isPlaying = true; // Video comienza a reproducirse
            }
        }

        private void VideoTimer_Tick(object sender, EventArgs e)
        {
            // Lee el siguiente cuadro
            _capture.Read(_frame);

            if (!_frame.IsEmpty)
            {
                // Aplica el filtro seleccionado
                ApplyFilterToFrame();

                // Redimensiona el cuadro del video para ajustarse al tamaño del PictureBox
                var resizedFrame = _frame.ToImage<Bgr, byte>().Resize(pb_video.Width, pb_video.Height, Emgu.CV.CvEnum.Inter.Linear);

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
        }


        // Aplica filtro sepia
        private void ApplySepiaFilter()
        {
            // Matriz para el filtro sepia
            Mat sepiaKernel = new Mat(3, 3, DepthType.Cv8U, 1);
            sepiaKernel.SetTo(new byte[] { 112, 66, 20, 70, 130, 95, 15, 33, 100 });
            CvInvoke.Transform(_frame, _frame, sepiaKernel);


        }



    }



}
