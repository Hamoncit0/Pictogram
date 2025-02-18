using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictogram
{
    internal class Filter
    {

        public Bitmap ApplyFishEye(Bitmap image)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    double nx = (2.0 * x / image.Width) - 1;
                    double ny = (2.0 * y / image.Height) - 1;
                    double r = Math.Sqrt(nx * nx + ny * ny);
                    double nr = Math.Sqrt(1 - r * r);
                    int srcX = (int)(((nx * nr + 1) * image.Width) / 2);
                    int srcY = (int)(((ny * nr + 1) * image.Height) / 2);
                    result.SetPixel(x, y, image.GetPixel(Clamp(srcX, 0, image.Width - 1), Clamp(srcY, 0, image.Height - 1)));
                }
            }
            return result;
        }

        public Bitmap ApplyThreshold(Bitmap image, int threshold)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int intensity = (pixel.R + pixel.G + pixel.B) / 3;
                    result.SetPixel(x, y, intensity >= threshold ? Color.White : Color.Black);
                }
            }
            return result;
        }

        private int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
        public Bitmap ApplyEdgeEnhancement(Bitmap image)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            for (int y = 1; y < image.Height - 1; y++)
            {
                for (int x = 1; x < image.Width - 1; x++)
                {
                    Color pixel1 = image.GetPixel(x - 1, y);
                    Color pixel2 = image.GetPixel(x + 1, y);
                    Color pixel3 = image.GetPixel(x, y - 1);
                    Color pixel4 = image.GetPixel(x, y + 1);

                    int r = Math.Abs(pixel1.R - pixel2.R) + Math.Abs(pixel3.R - pixel4.R);
                    int g = Math.Abs(pixel1.G - pixel2.G) + Math.Abs(pixel3.G - pixel4.G);
                    int b = Math.Abs(pixel1.B - pixel2.B) + Math.Abs(pixel3.B - pixel4.B);

                    result.SetPixel(x, y, Color.FromArgb(Clamp(r, 0, 255), Clamp(g, 0, 255), Clamp(b, 0, 255)));
                }
            }
            return result;
        }

        public Bitmap ApplyThermalCameraFilter(Bitmap image)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            // Definir los límites de temperaturas (esto es solo un ejemplo, ajusta según sea necesario)
            int minTemperature = 0;    // Mínima temperatura (Azul)
            int maxTemperature = 255;  // Máxima temperatura (Rojo)

            // Recorrer todos los píxeles de la imagen
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    // Obtener el color del píxel
                    Color pixel = image.GetPixel(x, y);

                    // Promediar los valores RGB para simular la "temperatura"
                    int intensity = (pixel.R + pixel.G + pixel.B) / 3;

                    // Normalizar el valor de la "temperatura" para que esté entre 0 y 255
                    int temperature = Math.Min(Math.Max((intensity), minTemperature), maxTemperature);

                    // Asignar colores en función de la "temperatura"
                    Color thermalColor;

                    if (temperature < 85)
                    {
                        // Azul para temperaturas bajas (frías)
                        int blueValue = 255 - (temperature * 3); // Azul más intenso a temperaturas más frías
                        thermalColor = Color.FromArgb(0, 0, blueValue);
                    }
                    else if (temperature < 170)
                    {
                        // Verde o Amarillo para temperaturas medias
                        int greenValue = (temperature - 85) * 3;
                        int redValue = (temperature - 85) * 2;

                        // Aquí se puede hacer que se vea más amarillo/verde dependiendo de la preferencia
                        thermalColor = Color.FromArgb(redValue, greenValue, 0); // Amarillo-verde
                    }
                    else
                    {
                        // Rojo para temperaturas altas (calientes)
                        int redValue = (temperature - 170) * 3;
                        thermalColor = Color.FromArgb(redValue, 0, 0); // Rojo
                    }

                    // Establecer el píxel en el nuevo color térmico
                    result.SetPixel(x, y, thermalColor);
                }
            }

            return result;
        }

        public Bitmap ApplyNoise(Bitmap image, int noiseAmount)
        {
            Random rand = new Random();
            Bitmap result = new Bitmap(image);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int noise = rand.Next(-noiseAmount, noiseAmount);
                    int r = Clamp(pixel.R + noise, 0, 255);
                    int g = Clamp(pixel.G + noise, 0, 255);
                    int b = Clamp(pixel.B + noise, 0, 255);
                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return result;
        }
        public Bitmap ApplyVignette(Bitmap image)
        {
            Bitmap result = new Bitmap(image);
            int centerX = image.Width / 2;
            int centerY = image.Height / 2;
            double maxDistance = Math.Sqrt(centerX * centerX + centerY * centerY);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    int dx = x - centerX;
                    int dy = y - centerY;
                    double distance = Math.Sqrt(dx * dx + dy * dy);
                    double factor = 1 - (distance / maxDistance);
                    Color pixel = image.GetPixel(x, y);
                    int r = (int)(pixel.R * factor);
                    int g = (int)(pixel.G * factor);
                    int b = (int)(pixel.B * factor);
                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return result;
        }

        public Bitmap ApplyPrismEffect(Bitmap image)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            // Dividir la imagen en cuatro partes y reflejarlas
            int width = image.Width / 2;
            int height = image.Height / 2;

            // Esquinas de la imagen reflejadas
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // Crear un efecto de espejo en las cuatro partes
                    if (x < width && y < height)
                    {
                        result.SetPixel(x, y, pixel);  // Esquina superior izquierda
                        result.SetPixel(image.Width - 1 - x, y, pixel);  // Esquina superior derecha
                        result.SetPixel(x, image.Height - 1 - y, pixel);  // Esquina inferior izquierda
                        result.SetPixel(image.Width - 1 - x, image.Height - 1 - y, pixel);  // Esquina inferior derecha
                    }
                }
            }

            return result;
        }

        public Bitmap ApplyCartoonEffect(Bitmap image)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            Bitmap edges = new Bitmap(image.Width, image.Height);

            // Umbral para simplificar los colores y aumentar contraste
            for (int y = 1; y < image.Height - 1; y++)
            {
                for (int x = 1; x < image.Width - 1; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // Umbral para simplificar el color
                    int r = pixel.R > 128 ? 255 : 0;
                    int g = pixel.G > 128 ? 255 : 0;
                    int b = pixel.B > 128 ? 255 : 0;

                    Color simplifiedColor = Color.FromArgb(r, g, b);
                    result.SetPixel(x, y, simplifiedColor);

                    // Detectar bordes simples comparando pixeles vecinos
                    Color left = image.GetPixel(x - 1, y);
                    Color right = image.GetPixel(x + 1, y);
                    Color top = image.GetPixel(x, y - 1);
                    Color bottom = image.GetPixel(x, y + 1);

                    int edgeDetect = Math.Abs(pixel.R - left.R) + Math.Abs(pixel.G - left.G) + Math.Abs(pixel.B - left.B);
                    edgeDetect += Math.Abs(pixel.R - right.R) + Math.Abs(pixel.G - right.G) + Math.Abs(pixel.B - right.B);
                    edgeDetect += Math.Abs(pixel.R - top.R) + Math.Abs(pixel.G - top.G) + Math.Abs(pixel.B - top.B);
                    edgeDetect += Math.Abs(pixel.R - bottom.R) + Math.Abs(pixel.G - bottom.G) + Math.Abs(pixel.B - bottom.B);

                    if (edgeDetect > 100) // Umbral de detección de bordes
                    {
                        result.SetPixel(x, y, Color.Black);  // Aplicar borde negro si hay contraste
                    }
                }
            }

            return result;
        }


        public Bitmap ApplyMosaic(Bitmap originalBitmap, int blockSize)
        {
            // Crear una nueva imagen con las mismas dimensiones que la original
            Bitmap newBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            // Recorrer la imagen en bloques
            for (int x = 0; x < originalBitmap.Width; x += blockSize)
            {
                for (int y = 0; y < originalBitmap.Height; y += blockSize)
                {
                    // Obtener el color promedio del bloque
                    Color averageColor = GetAverageColor(originalBitmap, x, y, blockSize);

                    // Rellenar el bloque con el color promedio
                    for (int i = 0; i < blockSize && x + i < originalBitmap.Width; i++)
                    {
                        for (int j = 0; j < blockSize && y + j < originalBitmap.Height; j++)
                        {
                            newBitmap.SetPixel(x + i, y + j, averageColor);
                        }
                    }
                }
            }

            return newBitmap;
        }

        private static Color GetAverageColor(Bitmap bitmap, int startX, int startY, int blockSize)
        {
            int totalRed = 0, totalGreen = 0, totalBlue = 0;
            int pixelCount = 0;

            // Recorrer los píxeles dentro del bloque
            for (int x = 0; x < blockSize && startX + x < bitmap.Width; x++)
            {
                for (int y = 0; y < blockSize && startY + y < bitmap.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(startX + x, startY + y);

                    totalRed += pixelColor.R;
                    totalGreen += pixelColor.G;
                    totalBlue += pixelColor.B;
                    pixelCount++;
                }
            }

            // Calcular el color promedio
            int avgRed = totalRed / pixelCount;
            int avgGreen = totalGreen / pixelCount;
            int avgBlue = totalBlue / pixelCount;

            return Color.FromArgb(avgRed, avgGreen, avgBlue);
        }

    }
}
