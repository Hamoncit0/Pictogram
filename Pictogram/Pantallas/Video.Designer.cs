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

                // Liberar recursos administrados
                if (_capture != null)
                {
                    _capture.Dispose();
                    _capture = null;
                }
                if (_frame != null)
                {
                    _frame.Dispose();
                    _frame = null;
                }
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
            this.btn_resetfilter = new System.Windows.Forms.Button();
            this.btn_upload_video = new System.Windows.Forms.Button();
            this.pb_video = new System.Windows.Forms.PictureBox();
            this.btn_pause_play = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb_histogramaB = new System.Windows.Forms.PictureBox();
            this.pb_histogramaG = new System.Windows.Forms.PictureBox();
            this.pb_histogramaR = new System.Windows.Forms.PictureBox();
            this.pb_histograma = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FlowPanelFilters = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_video)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histograma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_resetfilter
            // 
            this.btn_resetfilter.Enabled = false;
            this.btn_resetfilter.Location = new System.Drawing.Point(429, 299);
            this.btn_resetfilter.Name = "btn_resetfilter";
            this.btn_resetfilter.Size = new System.Drawing.Size(120, 38);
            this.btn_resetfilter.TabIndex = 17;
            this.btn_resetfilter.Text = "Reset filters";
            this.btn_resetfilter.UseVisualStyleBackColor = true;
            this.btn_resetfilter.Click += new System.EventHandler(this.btn_resetfilter_Click);
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
            this.btn_pause_play.Enabled = false;
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
            this.groupBox3.Controls.Add(this.pb_histogramaB);
            this.groupBox3.Controls.Add(this.pb_histogramaG);
            this.groupBox3.Controls.Add(this.pb_histogramaR);
            this.groupBox3.Controls.Add(this.pb_histograma);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(590, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 610);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Histograms";
            // 
            // pb_histogramaB
            // 
            this.pb_histogramaB.BackColor = System.Drawing.Color.White;
            this.pb_histogramaB.Location = new System.Drawing.Point(12, 431);
            this.pb_histogramaB.Name = "pb_histogramaB";
            this.pb_histogramaB.Size = new System.Drawing.Size(311, 128);
            this.pb_histogramaB.TabIndex = 7;
            this.pb_histogramaB.TabStop = false;
            // 
            // pb_histogramaG
            // 
            this.pb_histogramaG.BackColor = System.Drawing.Color.White;
            this.pb_histogramaG.Location = new System.Drawing.Point(12, 297);
            this.pb_histogramaG.Name = "pb_histogramaG";
            this.pb_histogramaG.Size = new System.Drawing.Size(311, 128);
            this.pb_histogramaG.TabIndex = 6;
            this.pb_histogramaG.TabStop = false;
            // 
            // pb_histogramaR
            // 
            this.pb_histogramaR.BackColor = System.Drawing.Color.White;
            this.pb_histogramaR.Location = new System.Drawing.Point(12, 163);
            this.pb_histogramaR.Name = "pb_histogramaR";
            this.pb_histogramaR.Size = new System.Drawing.Size(311, 128);
            this.pb_histogramaR.TabIndex = 5;
            this.pb_histogramaR.TabStop = false;
            // 
            // pb_histograma
            // 
            this.pb_histograma.BackColor = System.Drawing.Color.White;
            this.pb_histograma.Location = new System.Drawing.Point(12, 29);
            this.pb_histograma.Name = "pb_histograma";
            this.pb_histograma.Size = new System.Drawing.Size(311, 128);
            this.pb_histograma.TabIndex = 4;
            this.pb_histograma.TabStop = false;
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
            this.Controls.Add(this.btn_resetfilter);
            this.Controls.Add(this.btn_upload_video);
            this.Controls.Add(this.pb_video);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Video";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_video)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histograma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_resetfilter;
        private System.Windows.Forms.Button btn_upload_video;
        private System.Windows.Forms.PictureBox pb_video;
        private System.Windows.Forms.Button btn_pause_play;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelFilters;
        private System.Windows.Forms.PictureBox pb_histogramaB;
        private System.Windows.Forms.PictureBox pb_histogramaG;
        private System.Windows.Forms.PictureBox pb_histogramaR;
        private System.Windows.Forms.PictureBox pb_histograma;
    }
}