namespace Pictogram.Pantallas
{
    partial class Camara
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
            this.button1 = new System.Windows.Forms.Button();
            this.pb_color = new System.Windows.Forms.PictureBox();
            this.pb_camara = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_resetfilter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FlowPanelFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb_histogramaB = new System.Windows.Forms.PictureBox();
            this.pb_histogramaG = new System.Windows.Forms.PictureBox();
            this.pb_histogramaR = new System.Windows.Forms.PictureBox();
            this.pb_histograma = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_turnoncamara = new System.Windows.Forms.Button();
            this.btn_capture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camara)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histograma)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Detect color";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pb_color
            // 
            this.pb_color.BackColor = System.Drawing.Color.LightCoral;
            this.pb_color.Location = new System.Drawing.Point(33, 29);
            this.pb_color.Name = "pb_color";
            this.pb_color.Size = new System.Drawing.Size(96, 98);
            this.pb_color.TabIndex = 15;
            this.pb_color.TabStop = false;
            // 
            // pb_camara
            // 
            this.pb_camara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pb_camara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_camara.Location = new System.Drawing.Point(56, 33);
            this.pb_camara.Name = "pb_camara";
            this.pb_camara.Size = new System.Drawing.Size(457, 287);
            this.pb_camara.TabIndex = 13;
            this.pb_camara.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pb_color);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(404, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 173);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Detected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Coral";
            // 
            // btn_resetfilter
            // 
            this.btn_resetfilter.Enabled = false;
            this.btn_resetfilter.Location = new System.Drawing.Point(182, 341);
            this.btn_resetfilter.Name = "btn_resetfilter";
            this.btn_resetfilter.Size = new System.Drawing.Size(120, 38);
            this.btn_resetfilter.TabIndex = 23;
            this.btn_resetfilter.Text = "Reset filters";
            this.btn_resetfilter.UseVisualStyleBackColor = true;
            this.btn_resetfilter.Click += new System.EventHandler(this.btn_resetfilter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.FlowPanelFilters);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(12, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 224);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // FlowPanelFilters
            // 
            this.FlowPanelFilters.AutoScroll = true;
            this.FlowPanelFilters.AutoSize = true;
            this.FlowPanelFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelFilters.Location = new System.Drawing.Point(3, 26);
            this.FlowPanelFilters.Name = "FlowPanelFilters";
            this.FlowPanelFilters.Size = new System.Drawing.Size(380, 195);
            this.FlowPanelFilters.TabIndex = 14;
            this.FlowPanelFilters.WrapContents = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb_histogramaB);
            this.groupBox2.Controls.Add(this.pb_histogramaG);
            this.groupBox2.Controls.Add(this.pb_histogramaR);
            this.groupBox2.Controls.Add(this.pb_histograma);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(600, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 610);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histograms";
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
            // btn_turnoncamara
            // 
            this.btn_turnoncamara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_turnoncamara.Location = new System.Drawing.Point(308, 341);
            this.btn_turnoncamara.Name = "btn_turnoncamara";
            this.btn_turnoncamara.Size = new System.Drawing.Size(120, 38);
            this.btn_turnoncamara.TabIndex = 26;
            this.btn_turnoncamara.Text = "Encender camara";
            this.btn_turnoncamara.UseVisualStyleBackColor = true;
            this.btn_turnoncamara.Click += new System.EventHandler(this.btn_turnoncamara_Click);
            // 
            // btn_capture
            // 
            this.btn_capture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_capture.Location = new System.Drawing.Point(434, 341);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(120, 38);
            this.btn_capture.TabIndex = 27;
            this.btn_capture.Text = "Take picture";
            this.btn_capture.UseVisualStyleBackColor = true;
            // 
            // Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(941, 634);
            this.Controls.Add(this.btn_capture);
            this.Controls.Add(this.btn_turnoncamara);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_resetfilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_camara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Camara";
            this.Text = "Camara";
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camara)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_camara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_color;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_resetfilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelFilters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pb_histogramaB;
        private System.Windows.Forms.PictureBox pb_histogramaG;
        private System.Windows.Forms.PictureBox pb_histogramaR;
        private System.Windows.Forms.PictureBox pb_histograma;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_turnoncamara;
        private System.Windows.Forms.Button btn_capture;
    }
}