using Pictogram.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pictogram.Pantallas
{
    public partial class Fotos : Form
    {
        private Image originalImage;

        public Fotos()
        {
            InitializeComponent();
            // Agregar filtros
            AddFilterPanels();
        }


        private void AddFilterPanels()
        {
            string[] filterNames = { "Gris", "Sepia", "Brillo", "Inverso", "Ojo de pescado", "Umbral", "Realce de bordes", "Camara termica", "Ruido", "Viñeta", "Espejo", "Contraste", "Mosaico" };

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

        private void ApplyFilter(string filterType)
        {
            if (originalImage == null) return;

            Bitmap bmp = new Bitmap(originalImage);
            ColorMatrix colorMatrix = null;
            Filter filter = new Filter();
            switch (filterType)
            {
                case "Gris":
                    colorMatrix = new ColorMatrix(new float[][]
                    {
                    new float[] { 0.3f, 0.3f, 0.3f, 0, 0 },
                    new float[] { 0.59f, 0.59f, 0.59f, 0, 0 },
                    new float[] { 0.11f, 0.11f, 0.11f, 0, 0 },
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { 0, 0, 0, 0, 1 }
                    });
                    break;

                case "Sepia":
                    colorMatrix = new ColorMatrix(new float[][]
                    {
                    new float[] { 0.393f, 0.349f, 0.272f, 0, 0 },
                    new float[] { 0.769f, 0.686f, 0.534f, 0, 0 },
                    new float[] { 0.189f, 0.168f, 0.131f, 0, 0 },
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { 0, 0, 0, 0, 1 }
                    });
                    break;

                case "Inverso":
                    colorMatrix = new ColorMatrix(new float[][]
                    {
                    new float[] { -1, 0, 0, 0, 0 },
                    new float[] { 0, -1, 0, 0, 0 },
                    new float[] { 0, 0, -1, 0, 0 },
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { 1, 1, 1, 0, 1 }
                    });
                    break;

                case "Brillo":
                    colorMatrix = new ColorMatrix(new float[][]
                    {
                    new float[] { 1.2f, 0, 0, 0, 0 },
                    new float[] { 0, 1.2f, 0, 0, 0 },
                    new float[] { 0, 0, 1.2f, 0, 0 },
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { 0.1f, 0.1f, 0.1f, 0, 1 }
                    });
                    break;

                case "Ojo de pescado":
                    bmp = filter.ApplyFishEye(bmp);
                    CalculateHistogram(bmp);
                    pb_picture.Image = bmp;
                    if (!btn_reset_picture_filter.Enabled)
                        btn_reset_picture_filter.Enabled = true;
                    break;
                case "Umbral":
                    bmp = filter.ApplyThreshold(bmp, 120);
                    CalculateHistogram(bmp);
                    pb_picture.Image = bmp;
                    if (!btn_reset_picture_filter.Enabled)
                        btn_reset_picture_filter.Enabled = true;
                    break;
                case "Realce de bordes":
                    bmp = filter.ApplyEdgeEnhancement(bmp);
                    CalculateHistogram(bmp);
                    pb_picture.Image = bmp;
                    if (!btn_reset_picture_filter.Enabled)
                        btn_reset_picture_filter.Enabled = true;
                    break;
                case "Camara termica":
                    bmp = filter.ApplyThermalCameraFilter(bmp);
                    CalculateHistogram(bmp);
                    pb_picture.Image = bmp;
                    if (!btn_reset_picture_filter.Enabled)
                        btn_reset_picture_filter.Enabled = true;
                    break;
                case "Ruido":
                    bmp = filter.ApplyNoise(bmp, 144);
                    CalculateHistogram(bmp);
                    pb_picture.Image = bmp;
                    if (!btn_reset_picture_filter.Enabled)
                        btn_reset_picture_filter.Enabled = true;
                    break;
                case "Viñeta":
                    bmp = filter.ApplyVignette(bmp);
                    CalculateHistogram(bmp);
                    pb_picture.Image = bmp;
                    if (!btn_reset_picture_filter.Enabled)
                        btn_reset_picture_filter.Enabled = true;
                    break;
                case "Espejo":
                    bmp = filter.ApplyPrismEffect(bmp);
                    CalculateHistogram(bmp);
                    pb_picture.Image = bmp;
                    if (!btn_reset_picture_filter.Enabled)
                        btn_reset_picture_filter.Enabled = true;
                    break;
                case "Contraste":
                    bmp = filter.ApplyCartoonEffect(bmp);
                    CalculateHistogram(bmp);
                    pb_picture.Image = bmp;
                    if (!btn_reset_picture_filter.Enabled)
                        btn_reset_picture_filter.Enabled = true;
                    break;
                case "Mosaico":
                    bmp = filter.ApplyMosaic(bmp,20);
                    CalculateHistogram(bmp);
                    pb_picture.Image = bmp;
                    if (!btn_reset_picture_filter.Enabled)
                        btn_reset_picture_filter.Enabled = true;
                    break;
            }

            if (colorMatrix != null)
            {
                ApplyColorMatrix(bmp, colorMatrix);
                CalculateHistogram(bmp);
                pb_picture.Image = bmp;
                if(!btn_reset_picture_filter.Enabled)
                    btn_reset_picture_filter.Enabled = true;
            }
        }

        private void ApplyColorMatrix(Bitmap bmp, ColorMatrix colorMatrix)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            using (ImageAttributes attributes = new ImageAttributes())
            {
                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(originalImage, new Rectangle(0, 0, bmp.Width, bmp.Height),
                            0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);
            }
        }
        //Botones

        private void btn_upload_picture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Seleccionar una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = Image.FromFile(openFileDialog.FileName);
                    pb_picture.Image = new Bitmap(originalImage);
                    pb_picture.SizeMode = PictureBoxSizeMode.Zoom;
                    // Calcular y mostrar los histogramas
                    CalculateHistogram((Bitmap)originalImage);

                    btn_save_picture.Enabled = true;
                }
            }
        }
        private void btn_reset_picture_filter_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                pb_picture.Image = (Image)originalImage.Clone();  // Restaurar imagen original
                if (btn_reset_picture_filter.Enabled)
                    btn_reset_picture_filter.Enabled = false;

                // Calcular y mostrar los histogramas
                CalculateHistogram((Bitmap)originalImage);
            }
        }

        private void btn_save_picture_Click(object sender, EventArgs e)
        {
            if (pb_picture.Image == null) return;

            // Abrir un cuadro de diálogo para guardar el archivo
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Imagen PNG|*.png|Imagen JPEG|*.jpg|Imagen BMP|*.bmp";
                saveFileDialog.Title = "Guardar imagen";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la extensión seleccionada
                    string extension = System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower();

                    // Guardar la imagen en el formato seleccionado
                    switch (extension)
                    {
                        case ".png":
                            pb_picture.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                            break;
                        case ".jpg":
                            pb_picture.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                            break;
                        case ".bmp":
                            pb_picture.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                            break;
                        default:
                            MessageBox.Show("Formato no soportado.");
                            break;
                    }

                    MessageBox.Show("Imagen guardada exitosamente", "HUh", MessageBoxButtons.OK);
                }
            }
        }

        //Histrogramas
        private void CalculateHistogram(Bitmap image)
        {
            int[] redHistogram = new int[256];
            int[] greenHistogram = new int[256];
            int[] blueHistogram = new int[256];
            int[] generalHistogram = new int[256]; // Para el histograma general (RGB combinado)

            // Recorrer cada píxel de la imagen y contar las frecuencias
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    redHistogram[pixelColor.R]++;
                    greenHistogram[pixelColor.G]++;
                    blueHistogram[pixelColor.B]++;

                    // Promediar los colores para el histograma general
                    int averageColor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    generalHistogram[averageColor]++;
                }
            }

            // Llamar a la función para actualizar los charts con los datos
            UpdateHistogramCharts(redHistogram, greenHistogram, blueHistogram, generalHistogram);
        }
        private void UpdateHistogramCharts(int[] redHistogram, int[] greenHistogram, int[] blueHistogram, int[] generalHistogram)
        {
            // Limpiar los series actuales
            red_histogram.Series.Clear();
            green_histogram.Series.Clear();
            blue_histogram.Series.Clear();
            general_histogram.Series.Clear();

            // Crear las series para cada canal
            var redSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Rojo");
            var greenSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Verde");
            var blueSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Azul");

            // Crear las tres series para el histograma general (RGB)
            var redGeneralSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Rojo General");
            var greenGeneralSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Verde General");
            var blueGeneralSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Azul General");

            // Asignar tipos de gráfico (Columnas)
            redSeries.ChartType = greenSeries.ChartType = blueSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            redGeneralSeries.ChartType = greenGeneralSeries.ChartType = blueGeneralSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Asignar colores a las series
            redSeries.Color = Color.Red;
            greenSeries.Color = Color.Green;
            blueSeries.Color = Color.Blue;

            redGeneralSeries.Color = Color.Red;
            greenGeneralSeries.Color = Color.Green;
            blueGeneralSeries.Color = Color.Blue;

            // Llenar las series con los datos del histograma
            for (int i = 0; i < 256; i++)
            {
                redSeries.Points.AddXY(i, redHistogram[i]);
                greenSeries.Points.AddXY(i, greenHistogram[i]);
                blueSeries.Points.AddXY(i, blueHistogram[i]);

                // Para el histograma general, agregar los valores de cada canal en diferentes series
                redGeneralSeries.Points.AddXY(i, redHistogram[i]);
                greenGeneralSeries.Points.AddXY(i, greenHistogram[i]);
                blueGeneralSeries.Points.AddXY(i, blueHistogram[i]);
            }

            // Agregar las series a los charts
            red_histogram.Series.Add(redSeries);
            green_histogram.Series.Add(greenSeries);
            blue_histogram.Series.Add(blueSeries);

            // Agregar las series del histograma general
            general_histogram.Series.Add(redGeneralSeries);
            general_histogram.Series.Add(greenGeneralSeries);
            general_histogram.Series.Add(blueGeneralSeries);
        }

    }

}
