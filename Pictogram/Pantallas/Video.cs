﻿using Emgu.CV;
using Emgu.CV.Structure;
using Pictogram.Componentes;
using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using System.Linq;
using Emgu.CV.Reg;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using static Emgu.CV.ML.KNearest;
using System.Threading.Tasks;

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
            pb_video.SizeMode = PictureBoxSizeMode.Zoom; // Otras opciones: StretchImage, CenterImage, Normal
            AddFilterPanels();
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


                // Redimensiona el cuadro del video para ajustarse al tamaño del PictureBox
                var resizedFrame = _frame.ToImage<Bgr, byte>().Resize(pb_video.Width, pb_video.Height, Emgu.CV.CvEnum.Inter.Linear);
                
                if(_currentFilter == "None")
                // Muestra el cuadro redimensionado en el PictureBox
                pb_video.Image = resizedFrame.ToBitmap();

                // Aplica el filtro seleccionado
                ApplyFilterToFrame();

                // Convertir el frame en un histograma
                ComputeHistogramFromPictureBox();

                // Liberar el buffer de la imagen después de usarlo
                resizedFrame.Dispose();
            }
            else
            {
                // Reinicia el video al principio
                _capture.Set(Emgu.CV.CvEnum.CapProp.PosFrames, 0);
            }
        }


        // Agrega los paneles de filtro
        private void AddFilterPanels()
        {
            string[] filterNames = { "Gris", "Sepia", "Brillo", "Inverso", "Ojo de pescado", "Umbral", "Realce de bordes", "Camara termica", "Ruido", "Viñeta", "Espejo", "Contraste", "Mosaico" };

            foreach (string filter in filterNames)
            {
                string imagePath = @"Videos\" + filter + ".png";
                System.Drawing.Image loadedImage = System.Drawing.Image.FromFile(imagePath);

                FilterPanel panel = new FilterPanel
                {
                    FilterName = filter,
                    FilterImage = loadedImage
                };
                panel.setPanelCenter();
                panel.FilterClicked += (s, e) => ApplyFilter(((FilterPanel)s).FilterName);
                FlowPanelFilters.Controls.Add(panel);
            }
        }
        //Filtros
        private void ApplyFilter(string filterType)
        {
            _currentFilter = filterType;
        }

        private void ApplyFilterToFrame()
        {
            switch (_currentFilter)
            {
                case "Gris":
                    ApplyGrayscaleFilter(); 
                    break;
                case "Sepia":
                    ApplySepiaFilter(); 
                    break;
                case "Brillo":
                    ApplyBrightnessFilter(30); 
                    break;
                case "Inverso":
                    ApplyNegativeFilter();
                    break;
                case "Mosaico":
                    ApplyMosaicFilter(20); 
                    break;
                case "Contraste":
                    ApplyContrastFilter(100);
                    break;
                case "Ojo de pescado":
                    ApplyFisheyeFilter();
                    break;
                case "Umbral":
                    ApplyThresholdFilter(45);
                    break;
                case "Realce de bordes":
                    ApplyEdgeEnhancementFilter(); 
                    break;
                case "Camara termica":
                    ApplyThermalCameraFilter();
                    break;
                case "Ruido":
                    ApplyNoiseFilter(100);
                    break;
                case "Viñeta":
                    ApplyVignetteFilter(1); 
                    break;
                case "Espejo":
                    ApplyPrismaFilter(12); 
                    break;
                default:
                    break;
            }
            btn_resetfilter.Enabled = true;
        }

        private void ApplyGrayscaleFilter()
        {
            Bitmap frameBitmap = _frame.ToBitmap();
            BitmapData bmpData = frameBitmap.LockBits(new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                                                        ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            for (int y = 0; y < frameBitmap.Height; y++)
            {
                int offset = y * stride;
                for (int x = 0; x < frameBitmap.Width; x++)
                {
                    int index = offset + (x * 3);
                    byte r = pixelValues[index + 2];
                    byte g = pixelValues[index + 1];
                    byte b = pixelValues[index];
                    byte gray = (byte)(0.299 * r + 0.587 * g + 0.114 * b);
                    pixelValues[index] = gray; // B
                    pixelValues[index + 1] = gray; // G
                    pixelValues[index + 2] = gray; // R
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, bytes);
            frameBitmap.UnlockBits(bmpData);
            pb_video.Image = frameBitmap;
        }

        private void ApplySepiaFilter()
        {
            Bitmap frameBitmap = _frame.ToBitmap();
            BitmapData bmpData = frameBitmap.LockBits(new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                                                        ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            for (int y = 0; y < frameBitmap.Height; y++)
            {
                int offset = y * stride;
                for (int x = 0; x < frameBitmap.Width; x++)
                {
                    int index = offset + (x * 3);
                    byte r = pixelValues[index + 2];
                    byte g = pixelValues[index + 1];
                    byte b = pixelValues[index];

                    byte tr = (byte)Math.Min(255, (int)(0.393 * r + 0.769 * g + 0.189 * b));
                    byte tg = (byte)Math.Min(255, (int)(0.349 * r + 0.686 * g + 0.168 * b));
                    byte tb = (byte)Math.Min(255, (int)(0.272 * r + 0.534 * g + 0.131 * b));

                    pixelValues[index] = tb; // B
                    pixelValues[index + 1] = tg; // G
                    pixelValues[index + 2] = tr; // R
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, bytes);
            frameBitmap.UnlockBits(bmpData);
            pb_video.Image = frameBitmap;
        }

        // Aplica el filtro de brillo
        private void ApplyBrightnessFilter(int brightness)
        {
            Bitmap frameBitmap = _frame.ToBitmap();
            BitmapData bmpData = frameBitmap.LockBits(new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                                                        ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            for (int y = 0; y < frameBitmap.Height; y++)
            {
                int offset = y * stride;
                for (int x = 0; x < frameBitmap.Width; x++)
                {
                    int index = offset + (x * 3);
                    pixelValues[index] = (byte)Math.Min(255, pixelValues[index] + brightness); // B
                    pixelValues[index + 1] = (byte)Math.Min(255, pixelValues[index + 1] + brightness); // G
                    pixelValues[index + 2] = (byte)Math.Min(255, pixelValues[index + 2] + brightness); // R
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, bytes);
            frameBitmap.UnlockBits(bmpData);
            pb_video.Image = frameBitmap;
        }

        private void ApplyNegativeFilter()
        {
            Bitmap frameBitmap = _frame.ToBitmap();
            BitmapData bmpData = frameBitmap.LockBits(new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                                                        ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            for (int y = 0; y < frameBitmap.Height; y++)
            {
                int offset = y * stride;
                for (int x = 0; x < frameBitmap.Width; x++)
                {
                    int index = offset + (x * 3);
                    pixelValues[index] = (byte)(255 - pixelValues[index]); // B
                    pixelValues[index + 1] = (byte)(255 - pixelValues[index + 1]); // G
                    pixelValues[index + 2] = (byte)(255 - pixelValues[index + 2]); // R
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, bytes);
            frameBitmap.UnlockBits(bmpData);
           

            pb_video.Image = frameBitmap;
        }
        private void ApplyMosaicFilter(int blockSize)
        {
            Bitmap frameBitmap = _frame.ToBitmap();
            BitmapData bmpData = frameBitmap.LockBits(new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                                                        ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            for (int y = 0; y < frameBitmap.Height; y += blockSize)
            {
                for (int x = 0; x < frameBitmap.Width; x += blockSize)
                {
                    int blockStartIndex = (y * stride) + (x * 3);
                    byte r = pixelValues[blockStartIndex + 2];
                    byte g = pixelValues[blockStartIndex + 1];
                    byte b = pixelValues[blockStartIndex];

                    // Apply the block color to the whole block
                    for (int dy = 0; dy < blockSize && (y + dy) < frameBitmap.Height; dy++)
                    {
                        for (int dx = 0; dx < blockSize && (x + dx) < frameBitmap.Width; dx++)
                        {
                            int index = ((y + dy) * stride) + ((x + dx) * 3);
                            pixelValues[index] = b;
                            pixelValues[index + 1] = g;
                            pixelValues[index + 2] = r;
                        }
                    }
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, bytes);
            frameBitmap.UnlockBits(bmpData);
            pb_video.Image = frameBitmap;
        }
        private void ApplyContrastFilter(double contrast)
        {
            Bitmap frameBitmap = _frame.ToBitmap();
            BitmapData bmpData = frameBitmap.LockBits(new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                                                        ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            double factor = (259 * (contrast + 255)) / (255 * (259 - contrast));

            for (int y = 0; y < frameBitmap.Height; y++)
            {
                int offset = y * stride;
                for (int x = 0; x < frameBitmap.Width; x++)
                {
                    int index = offset + (x * 3);
                    pixelValues[index] = (byte)Math.Min(255, Math.Max(0, factor * (pixelValues[index] - 128) + 128)); // B
                    pixelValues[index + 1] = (byte)Math.Min(255, Math.Max(0, factor * (pixelValues[index + 1] - 128) + 128)); // G
                    pixelValues[index + 2] = (byte)Math.Min(255, Math.Max(0, factor * (pixelValues[index + 2] - 128) + 128)); // R
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, bytes);
            frameBitmap.UnlockBits(bmpData);
            pb_video.Image = frameBitmap;
        }

        private void ApplyFisheyeFilter()
        {
            using (Mat mapX = new Mat(_frame.Size, DepthType.Cv32F, 1))
            using (Mat mapY = new Mat(_frame.Size, DepthType.Cv32F, 1))
            {
                int rows = _frame.Rows;
                int cols = _frame.Cols;
                float halfCols = cols / 2.0f;
                float halfRows = rows / 2.0f;

                unsafe
                {
                    float* mapXPtr = (float*)mapX.DataPointer.ToPointer();
                    float* mapYPtr = (float*)mapY.DataPointer.ToPointer();

                    Parallel.For(0, rows, i =>
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            float x = (2.0f * j / cols) - 1;
                            float y = (2.0f * i / rows) - 1;
                            float r = (float)Math.Sqrt(x * x + y * y);
                            float theta = (float)Math.Atan2(y, x);
                            float r_distorted = r * (1 + 0.5f * r * r);
                            float cosTheta = (float)Math.Cos(theta);
                            float sinTheta = (float)Math.Sin(theta);
                            float u = (r_distorted * cosTheta + 1) * halfCols;
                            float v = (r_distorted * sinTheta + 1) * halfRows;

                            int index = i * cols + j;
                            mapXPtr[index] = u;
                            mapYPtr[index] = v;
                        }
                    });
                }

                CvInvoke.Remap(_frame, _frame, mapX, mapY, Inter.Linear);

                // Actualizar el PictureBox de manera segura
                if (pb_video.InvokeRequired)
                {
                    pb_video.Invoke(new Action(() => pb_video.Image = _frame.ToBitmap()));
                }
                else
                {
                    pb_video.Image = _frame.ToBitmap();
                }
            }
        }
        private void ApplyThresholdFilter(int thresholdValue)
        {
            Bitmap frameBitmap = _frame.ToBitmap();

            // Bloquear los bits de la imagen para acceso directo
            BitmapData bmpData = frameBitmap.LockBits(
                new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb
            );

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];

            // Copiar los datos de la imagen al array de bytes
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            // Aplicar el filtro de umbral
            for (int y = 0; y < frameBitmap.Height; y++)
            {
                int offset = y * stride;
                for (int x = 0; x < frameBitmap.Width; x++)
                {
                    int index = offset + (x * 3); // 3 bytes por píxel (Format24bppRgb)

                    // Convertir a escala de grises usando el método de luminosidad
                    byte r = pixelValues[index + 2];
                    byte g = pixelValues[index + 1];
                    byte b = pixelValues[index];
                    byte gray = (byte)(0.299 * r + 0.587 * g + 0.114 * b);

                    // Aplicar el umbral
                    byte binaryValue = (gray > thresholdValue) ? (byte)255 : (byte)0;

                    // Asignar el valor binario a los 3 canales (R, G, B)
                    pixelValues[index] = binaryValue;     // B
                    pixelValues[index + 1] = binaryValue; // G
                    pixelValues[index + 2] = binaryValue; // R
                }
            }

            // Copiar los datos modificados de vuelta a la imagen
            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, bytes);

            // Desbloquear los bits de la imagen
            frameBitmap.UnlockBits(bmpData);

            if (pb_video.InvokeRequired)
            {
                pb_video.Invoke(new Action(() => pb_video.Image = frameBitmap));
            }
            else
            {
                pb_video.Image = frameBitmap;
            }
        }
        private void ApplyEdgeEnhancementFilter()
        {
            Bitmap frameBitmap = _frame.ToBitmap();

            BitmapData bmpData = frameBitmap.LockBits(
                new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb
            );

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];
            byte[] resultValues = new byte[bytes];

            // Copiar los datos de la imagen al array de bytes
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            // Definir el kernel Laplaciano para realce de bordes
            int[,] laplacianKernel = {
        { -1, -1, -1 },
        { -1,  8, -1 },
        { -1, -1, -1 }
    };

            int kernelSize = 3;
            int kernelRadius = kernelSize / 2;

            // Aplicar el filtro de convolución
            for (int y = kernelRadius; y < frameBitmap.Height - kernelRadius; y++)
            {
                for (int x = kernelRadius; x < frameBitmap.Width - kernelRadius; x++)
                {
                    int index = y * stride + x * 3;

                    // Inicializar acumuladores para cada canal (R, G, B)
                    int sumR = 0, sumG = 0, sumB = 0;

                    // Aplicar el kernel Laplaciano
                    for (int ky = -kernelRadius; ky <= kernelRadius; ky++)
                    {
                        for (int kx = -kernelRadius; kx <= kernelRadius; kx++)
                        {
                            int pixelIndex = (y + ky) * stride + (x + kx) * 3;

                            // Obtener los valores de los píxeles vecinos
                            byte r = pixelValues[pixelIndex + 2];
                            byte g = pixelValues[pixelIndex + 1];
                            byte b = pixelValues[pixelIndex];

                            // Multiplicar por el kernel y acumular
                            int kernelValue = laplacianKernel[ky + kernelRadius, kx + kernelRadius];
                            sumR += r * kernelValue;
                            sumG += g * kernelValue;
                            sumB += b * kernelValue;
                        }
                    }

                    // Asegurar que los valores estén en el rango [0, 255]
                    resultValues[index] = (byte)Math.Min(255, Math.Max(0, sumB)); // B
                    resultValues[index + 1] = (byte)Math.Min(255, Math.Max(0, sumG)); // G
                    resultValues[index + 2] = (byte)Math.Min(255, Math.Max(0, sumR)); // R
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(resultValues, 0, ptr, bytes);

            frameBitmap.UnlockBits(bmpData);

            if (pb_video.InvokeRequired)
            {
                pb_video.Invoke(new Action(() => pb_video.Image = frameBitmap));
            }
            else
            {
                pb_video.Image = frameBitmap;
            }
        }
        private void ApplyThermalCameraFilter()
        {
            Bitmap frameBitmap = _frame.ToBitmap();

            // Bloquear los bits de la imagen para acceso directo
            BitmapData bmpData = frameBitmap.LockBits(
                new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb
            );

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            for (int y = 0; y < frameBitmap.Height; y++)
            {
                for (int x = 0; x < frameBitmap.Width; x++)
                {
                    int index = y * stride + x * 3;

                    // Obtener los valores de los píxeles (R, G, B)
                    byte r = pixelValues[index + 2];
                    byte g = pixelValues[index + 1];
                    byte b = pixelValues[index];

                    // Convertir a escala de grises (intensidad)
                    byte intensity = (byte)(0.299 * r + 0.587 * g + 0.114 * b);

                    // Mapear la intensidad a un color térmico (azul -> rojo)
                    byte thermalR, thermalG, thermalB;
                    MapIntensityToThermalColor(intensity, out thermalR, out thermalG, out thermalB);

                    // Asignar el nuevo color térmico
                    pixelValues[index] = thermalB;     // B
                    pixelValues[index + 1] = thermalG; // G
                    pixelValues[index + 2] = thermalR; // R
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, bytes);

            frameBitmap.UnlockBits(bmpData);

            if (pb_video.InvokeRequired)
            {
                pb_video.Invoke(new Action(() => pb_video.Image = frameBitmap));
            }
            else
            {
                pb_video.Image = frameBitmap;
            }
        }

        // Mapear la intensidad a un color térmico
        private void MapIntensityToThermalColor(byte intensity, out byte r, out byte g, out byte b)
        {
            // Definir un mapa de colores térmicos (azul -> rojo)
            if (intensity < 64)
            {
                // Azul (frío)
                r = 0;
                g = 0;
                b = (byte)(intensity * 4);
            }
            else if (intensity < 128)
            {
                // Verde (templado)
                r = 0;
                g = (byte)((intensity - 64) * 4);
                b = (byte)(255 - (intensity - 64) * 4);
            }
            else if (intensity < 192)
            {
                // Amarillo (cálido)
                r = (byte)((intensity - 128) * 4);
                g = 255;
                b = 0;
            }
            else
            {
                // Rojo (caliente)
                r = 255;
                g = (byte)(255 - (intensity - 192) * 4);
                b = 0;
            }
        }

        private void ApplyNoiseFilter(int noiseIntensity)
        {
            Bitmap frameBitmap = _frame.ToBitmap();

            // Bloquear los bits de la imagen para acceso directo
            BitmapData bmpData = frameBitmap.LockBits(
                new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb
            );

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            Random random = new Random();

            for (int i = 0; i < bytes; i += 3)
            {
                // Generar un valor de ruido aleatorio
                int noise = random.Next(-noiseIntensity, noiseIntensity + 1);

                // Aplicar el ruido a cada canal (R, G, B)
                pixelValues[i] = (byte)Math.Min(255, Math.Max(0, pixelValues[i] + noise));     // B
                pixelValues[i + 1] = (byte)Math.Min(255, Math.Max(0, pixelValues[i + 1] + noise)); // G
                pixelValues[i + 2] = (byte)Math.Min(255, Math.Max(0, pixelValues[i + 2] + noise)); // R
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, bytes);

            frameBitmap.UnlockBits(bmpData);

            if (pb_video.InvokeRequired)
            {
                pb_video.Invoke(new Action(() => pb_video.Image = frameBitmap));
            }
            else
            {
                pb_video.Image = frameBitmap;
            }
        }
        private void ApplyVignetteFilter(double vignetteStrength)
        {
            Bitmap frameBitmap = _frame.ToBitmap();

            BitmapData bmpData = frameBitmap.LockBits(
                new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb
            );

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];

            // Copiar los datos de la imagen al array de bytes
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            // Calcular el centro de la imagen
            int centerX = frameBitmap.Width / 2;
            int centerY = frameBitmap.Height / 2;

            // Calcular el radio máximo (distancia desde el centro hasta una esquina)
            double maxRadius = Math.Sqrt(centerX * centerX + centerY * centerY);

            // Aplicar el filtro de viñeta
            for (int y = 0; y < frameBitmap.Height; y++)
            {
                for (int x = 0; x < frameBitmap.Width; x++)
                {
                    int index = y * stride + x * 3;

                    // Calcular la distancia desde el píxel actual al centro
                    double distance = Math.Sqrt((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY));

                    // Calcular el factor de viñeta (1 en el centro, 0 en los bordes)
                    double vignetteFactor = 1 - (distance / maxRadius) * vignetteStrength;

                    // Aplicar el factor de viñeta a cada canal (R, G, B)
                    pixelValues[index] = (byte)(pixelValues[index] * vignetteFactor);     // B
                    pixelValues[index + 1] = (byte)(pixelValues[index + 1] * vignetteFactor); // G
                    pixelValues[index + 2] = (byte)(pixelValues[index + 2] * vignetteFactor); // R
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, bytes);

            frameBitmap.UnlockBits(bmpData);

            if (pb_video.InvokeRequired)
            {
                pb_video.Invoke(new Action(() => pb_video.Image = frameBitmap));
            }
            else
            {
                pb_video.Image = frameBitmap;
            }
        }


        private void ApplyPrismaFilter(int numSectors)
        {
            Bitmap frameBitmap = _frame.ToBitmap();

            BitmapData bmpData = frameBitmap.LockBits(
                new Rectangle(0, 0, frameBitmap.Width, frameBitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb
            );

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * frameBitmap.Height;
            byte[] pixelValues = new byte[bytes];
            byte[] resultValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            // Calcular el centro de la imagen
            int centerX = frameBitmap.Width / 2;
            int centerY = frameBitmap.Height / 2;

            // Calcular el ángulo de cada sector
            double sectorAngle = 360.0 / numSectors;

            // Aplicar el filtro de prisma (kaleidoscopio)
            for (int y = 0; y < frameBitmap.Height; y++)
            {
                for (int x = 0; x < frameBitmap.Width; x++)
                {
                    // Calcular la distancia y el ángulo desde el centro
                    double dx = x - centerX;
                    double dy = y - centerY;
                    double distance = Math.Sqrt(dx * dx + dy * dy);
                    double angle = Math.Atan2(dy, dx) * (180 / Math.PI);

                    // Normalizar el ángulo a [0, 360)
                    if (angle < 0) angle += 360;

                    // Calcular el sector correspondiente
                    int sector = (int)(angle / sectorAngle) % numSectors;

                    // Calcular el ángulo reflejado dentro del sector
                    double reflectedAngle = sector * sectorAngle + (sectorAngle - (angle % sectorAngle));

                    // Convertir el ángulo reflejado a radianes
                    double reflectedRadians = reflectedAngle * (Math.PI / 180);

                    // Calcular las coordenadas reflejadas
                    int reflectedX = (int)(centerX + distance * Math.Cos(reflectedRadians));
                    int reflectedY = (int)(centerY + distance * Math.Sin(reflectedRadians));

                    // Asegurar que las coordenadas reflejadas estén dentro de los límites de la imagen
                    reflectedX = Math.Max(0, Math.Min(frameBitmap.Width - 1, reflectedX));
                    reflectedY = Math.Max(0, Math.Min(frameBitmap.Height - 1, reflectedY));

                    // Obtener el índice del píxel reflejado
                    int reflectedIndex = reflectedY * stride + reflectedX * 3;

                    // Obtener el índice del píxel actual
                    int currentIndex = y * stride + x * 3;

                    // Copiar los valores del píxel reflejado al píxel actual
                    resultValues[currentIndex] = pixelValues[reflectedIndex];     // B
                    resultValues[currentIndex + 1] = pixelValues[reflectedIndex + 1]; // G
                    resultValues[currentIndex + 2] = pixelValues[reflectedIndex + 2]; // R
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(resultValues, 0, ptr, bytes);

            frameBitmap.UnlockBits(bmpData);

            // Actualizar el PictureBox
            if (pb_video.InvokeRequired)
            {
                pb_video.Invoke(new Action(() => pb_video.Image = frameBitmap));
            }
            else
            {
                pb_video.Image = frameBitmap;
            }
        }
        //histogramas
        private void ComputeHistogramFromPictureBox()
        {
            // Obtener la imagen actual del PictureBox
            Bitmap bitmap = (Bitmap)pb_video.Image;

            // Verificar si la imagen es válida
            if (bitmap == null)
                return;

            // Inicializar los histogramas para R, G y B
            int[] histogramR = new int[256];
            int[] histogramG = new int[256];
            int[] histogramB = new int[256];

            // Bloquear los bits de la imagen para acceso directo
            BitmapData bmpData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb
            );

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * bitmap.Height;
            byte[] pixelValues = new byte[bytes];

            // Copiar los datos de la imagen al array de bytes
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixelValues, 0, bytes);

            // Calcular los histogramas
            for (int y = 0; y < bitmap.Height; y++)
            {
                int offset = y * stride;
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int index = offset + (x * 3);
                    byte b = pixelValues[index];      // Canal Azul
                    byte g = pixelValues[index + 1];  // Canal Verde
                    byte r = pixelValues[index + 2];  // Canal Rojo

                    histogramR[r]++;
                    histogramG[g]++;
                    histogramB[b]++;
                }
            }

            // Desbloquear los bits de la imagen
            bitmap.UnlockBits(bmpData);

            // Dibujar los histogramas
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
        //botones

        private void btn_resetfilter_Click(object sender, EventArgs e)
        {
            _currentFilter = "None";
            btn_resetfilter.Enabled = false;
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

    }



}
