namespace Pictogram.Pantallas
{
    partial class Fotos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend29 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend30 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea31 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend31 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea32 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend32 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btn_upload_picture = new System.Windows.Forms.Button();
            this.btn_save_picture = new System.Windows.Forms.Button();
            this.btn_reset_picture_filter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.general_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.red_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.green_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.blue_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FlowPanelFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.general_histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_histogram)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_upload_picture
            // 
            this.btn_upload_picture.Location = new System.Drawing.Point(112, 333);
            this.btn_upload_picture.Name = "btn_upload_picture";
            this.btn_upload_picture.Size = new System.Drawing.Size(120, 38);
            this.btn_upload_picture.TabIndex = 1;
            this.btn_upload_picture.Text = "Upload picture";
            this.btn_upload_picture.UseVisualStyleBackColor = true;
            this.btn_upload_picture.Click += new System.EventHandler(this.btn_upload_picture_Click);
            // 
            // btn_save_picture
            // 
            this.btn_save_picture.Enabled = false;
            this.btn_save_picture.Location = new System.Drawing.Point(367, 333);
            this.btn_save_picture.Name = "btn_save_picture";
            this.btn_save_picture.Size = new System.Drawing.Size(120, 38);
            this.btn_save_picture.TabIndex = 10;
            this.btn_save_picture.Text = "Save picture";
            this.btn_save_picture.UseVisualStyleBackColor = true;
            this.btn_save_picture.Click += new System.EventHandler(this.btn_save_picture_Click);
            // 
            // btn_reset_picture_filter
            // 
            this.btn_reset_picture_filter.Enabled = false;
            this.btn_reset_picture_filter.Location = new System.Drawing.Point(241, 333);
            this.btn_reset_picture_filter.Name = "btn_reset_picture_filter";
            this.btn_reset_picture_filter.Size = new System.Drawing.Size(120, 38);
            this.btn_reset_picture_filter.TabIndex = 11;
            this.btn_reset_picture_filter.Text = "Reset filters";
            this.btn_reset_picture_filter.UseVisualStyleBackColor = true;
            this.btn_reset_picture_filter.Click += new System.EventHandler(this.btn_reset_picture_filter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.blue_histogram);
            this.groupBox2.Controls.Add(this.green_histogram);
            this.groupBox2.Controls.Add(this.red_histogram);
            this.groupBox2.Controls.Add(this.general_histogram);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(612, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 634);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histograms";
            // 
            // general_histogram
            // 
            chartArea29.Name = "ChartArea1";
            this.general_histogram.ChartAreas.Add(chartArea29);
            legend29.Name = "Legend1";
            this.general_histogram.Legends.Add(legend29);
            this.general_histogram.Location = new System.Drawing.Point(6, 29);
            this.general_histogram.Name = "general_histogram";
            this.general_histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series22.ChartArea = "ChartArea1";
            series22.Legend = "Legend1";
            series22.Name = "Red";
            series22.ShadowColor = System.Drawing.Color.Silver;
            series23.ChartArea = "ChartArea1";
            series23.Legend = "Legend1";
            series23.Name = "Green";
            series24.ChartArea = "ChartArea1";
            series24.Legend = "Legend1";
            series24.Name = "Blue";
            this.general_histogram.Series.Add(series22);
            this.general_histogram.Series.Add(series23);
            this.general_histogram.Series.Add(series24);
            this.general_histogram.Size = new System.Drawing.Size(317, 140);
            this.general_histogram.TabIndex = 0;
            this.general_histogram.Text = "chart1";
            // 
            // red_histogram
            // 
            chartArea30.Name = "ChartArea1";
            this.red_histogram.ChartAreas.Add(chartArea30);
            legend30.Name = "Legend1";
            this.red_histogram.Legends.Add(legend30);
            this.red_histogram.Location = new System.Drawing.Point(6, 175);
            this.red_histogram.Name = "red_histogram";
            this.red_histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.red_histogram.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.red_histogram.Size = new System.Drawing.Size(317, 140);
            this.red_histogram.TabIndex = 1;
            this.red_histogram.Text = "chart2";
            // 
            // green_histogram
            // 
            chartArea31.Name = "ChartArea1";
            this.green_histogram.ChartAreas.Add(chartArea31);
            legend31.Name = "Legend1";
            this.green_histogram.Legends.Add(legend31);
            this.green_histogram.Location = new System.Drawing.Point(6, 321);
            this.green_histogram.Name = "green_histogram";
            this.green_histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.green_histogram.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            this.green_histogram.Size = new System.Drawing.Size(317, 140);
            this.green_histogram.TabIndex = 2;
            this.green_histogram.Text = "chart3";
            // 
            // blue_histogram
            // 
            chartArea32.Name = "ChartArea1";
            this.blue_histogram.ChartAreas.Add(chartArea32);
            legend32.Name = "Legend1";
            this.blue_histogram.Legends.Add(legend32);
            this.blue_histogram.Location = new System.Drawing.Point(6, 467);
            this.blue_histogram.Name = "blue_histogram";
            this.blue_histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.blue_histogram.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            this.blue_histogram.Size = new System.Drawing.Size(317, 140);
            this.blue_histogram.TabIndex = 3;
            this.blue_histogram.Text = "chart4";
            // 
            // FlowPanelFilters
            // 
            this.FlowPanelFilters.AutoScroll = true;
            this.FlowPanelFilters.AutoSize = true;
            this.FlowPanelFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelFilters.Location = new System.Drawing.Point(3, 26);
            this.FlowPanelFilters.Name = "FlowPanelFilters";
            this.FlowPanelFilters.Size = new System.Drawing.Size(502, 195);
            this.FlowPanelFilters.TabIndex = 14;
            this.FlowPanelFilters.WrapContents = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.FlowPanelFilters);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(36, 395);
            this.groupBox1.MaximumSize = new System.Drawing.Size(800, 224);
            this.groupBox1.MinimumSize = new System.Drawing.Size(508, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 224);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // pb_picture
            // 
            this.pb_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pb_picture.BackgroundImage = global::Pictogram.Properties.Resources.upload_icon_white_spaced;
            this.pb_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_picture.Location = new System.Drawing.Point(45, 12);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(493, 315);
            this.pb_picture.TabIndex = 0;
            this.pb_picture.TabStop = false;
            // 
            // Fotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(941, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_reset_picture_filter);
            this.Controls.Add(this.btn_save_picture);
            this.Controls.Add(this.btn_upload_picture);
            this.Controls.Add(this.pb_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fotos";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.general_histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_histogram)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.Button btn_upload_picture;
        private System.Windows.Forms.Button btn_save_picture;
        private System.Windows.Forms.Button btn_reset_picture_filter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart general_histogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart blue_histogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart green_histogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart red_histogram;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelFilters;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}