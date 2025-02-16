namespace Pictogram.Pantallas
{
    partial class Video
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_upload_video = new System.Windows.Forms.Button();
            this.pb_video = new System.Windows.Forms.PictureBox();
            this.btn_pause_play = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.blue_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.green_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.red_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.general_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FlowPanelFilters = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_video)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blue_histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_histogram)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(429, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "Reset filters";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_upload_video
            // 
            this.btn_upload_video.Location = new System.Drawing.Point(51, 299);
            this.btn_upload_video.Name = "btn_upload_video";
            this.btn_upload_video.Size = new System.Drawing.Size(120, 38);
            this.btn_upload_video.TabIndex = 15;
            this.btn_upload_video.Text = "Upload video";
            this.btn_upload_video.UseVisualStyleBackColor = true;
            this.btn_upload_video.Click += new System.EventHandler(this.btn_upload_video_Click);
            // 
            // pb_video
            // 
            this.pb_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pb_video.BackgroundImage = global::Pictogram.Properties.Resources.upload_video_icon;
            this.pb_video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_video.Location = new System.Drawing.Point(37, 48);
            this.pb_video.Name = "pb_video";
            this.pb_video.Size = new System.Drawing.Size(508, 245);
            this.pb_video.TabIndex = 14;
            this.pb_video.TabStop = false;
            // 
            // btn_pause_play
            // 
            this.btn_pause_play.Location = new System.Drawing.Point(235, 299);
            this.btn_pause_play.Name = "btn_pause_play";
            this.btn_pause_play.Size = new System.Drawing.Size(120, 38);
            this.btn_pause_play.TabIndex = 20;
            this.btn_pause_play.Text = "Play/Pause";
            this.btn_pause_play.UseVisualStyleBackColor = true;
            this.btn_pause_play.Click += new System.EventHandler(this.btn_pause_play_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.blue_histogram);
            this.groupBox3.Controls.Add(this.green_histogram);
            this.groupBox3.Controls.Add(this.red_histogram);
            this.groupBox3.Controls.Add(this.general_histogram);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(590, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 610);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Histograms";
            // 
            // blue_histogram
            // 
            chartArea5.Name = "ChartArea1";
            this.blue_histogram.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.blue_histogram.Legends.Add(legend5);
            this.blue_histogram.Location = new System.Drawing.Point(6, 467);
            this.blue_histogram.Name = "blue_histogram";
            this.blue_histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Red";
            series13.ShadowColor = System.Drawing.Color.Silver;
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Green";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Blue";
            this.blue_histogram.Series.Add(series13);
            this.blue_histogram.Series.Add(series14);
            this.blue_histogram.Series.Add(series15);
            this.blue_histogram.Size = new System.Drawing.Size(317, 140);
            this.blue_histogram.TabIndex = 3;
            this.blue_histogram.Text = "chart4";
            // 
            // green_histogram
            // 
            chartArea6.Name = "ChartArea1";
            this.green_histogram.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.green_histogram.Legends.Add(legend6);
            this.green_histogram.Location = new System.Drawing.Point(6, 321);
            this.green_histogram.Name = "green_histogram";
            this.green_histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Red";
            series16.ShadowColor = System.Drawing.Color.Silver;
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Green";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Blue";
            this.green_histogram.Series.Add(series16);
            this.green_histogram.Series.Add(series17);
            this.green_histogram.Series.Add(series18);
            this.green_histogram.Size = new System.Drawing.Size(317, 140);
            this.green_histogram.TabIndex = 2;
            this.green_histogram.Text = "chart3";
            // 
            // red_histogram
            // 
            chartArea7.Name = "ChartArea1";
            this.red_histogram.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.red_histogram.Legends.Add(legend7);
            this.red_histogram.Location = new System.Drawing.Point(6, 175);
            this.red_histogram.Name = "red_histogram";
            this.red_histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Red";
            series19.ShadowColor = System.Drawing.Color.Silver;
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Green";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Blue";
            this.red_histogram.Series.Add(series19);
            this.red_histogram.Series.Add(series20);
            this.red_histogram.Series.Add(series21);
            this.red_histogram.Size = new System.Drawing.Size(317, 140);
            this.red_histogram.TabIndex = 1;
            this.red_histogram.Text = "chart2";
            // 
            // general_histogram
            // 
            chartArea8.Name = "ChartArea1";
            this.general_histogram.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.general_histogram.Legends.Add(legend8);
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
            this.general_histogram.Text = "chart5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FlowPanelFilters);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(37, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 224);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // FlowPanelFilters
            // 
            this.FlowPanelFilters.AutoScroll = true;
            this.FlowPanelFilters.Location = new System.Drawing.Point(6, 29);
            this.FlowPanelFilters.Name = "FlowPanelFilters";
            this.FlowPanelFilters.Size = new System.Drawing.Size(535, 189);
            this.FlowPanelFilters.TabIndex = 14;
            this.FlowPanelFilters.WrapContents = false;
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(941, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_pause_play);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_upload_video);
            this.Controls.Add(this.pb_video);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Video";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_video)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blue_histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_histogram)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_upload_video;
        private System.Windows.Forms.PictureBox pb_video;
        private System.Windows.Forms.Button btn_pause_play;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart blue_histogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart green_histogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart red_histogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart general_histogram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelFilters;
    }
}