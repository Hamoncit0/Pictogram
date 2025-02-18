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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FlowPanelFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb_histogramaB = new System.Windows.Forms.PictureBox();
            this.pb_histogramaG = new System.Windows.Forms.PictureBox();
            this.pb_histogramaR = new System.Windows.Forms.PictureBox();
            this.pb_histograma = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox2.Location = new System.Drawing.Point(33, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 98);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(56, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 287);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
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
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(182, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 38);
            this.button3.TabIndex = 23;
            this.button3.Text = "Reset filters";
            this.button3.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 38);
            this.button2.TabIndex = 26;
            this.button2.Text = "Encender camara";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(941, 634);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Camara";
            this.Text = "Camara";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelFilters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pb_histogramaB;
        private System.Windows.Forms.PictureBox pb_histogramaG;
        private System.Windows.Forms.PictureBox pb_histogramaR;
        private System.Windows.Forms.PictureBox pb_histograma;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
    }
}