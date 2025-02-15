namespace Pictogram.Componentes
{
    partial class FilterPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_filtername = new System.Windows.Forms.Label();
            this.pb_filterimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_filterimage)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_filtername
            // 
            this.lb_filtername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_filtername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filtername.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_filtername.Location = new System.Drawing.Point(0, 120);
            this.lb_filtername.Name = "lb_filtername";
            this.lb_filtername.Size = new System.Drawing.Size(160, 51);
            this.lb_filtername.TabIndex = 3;
            this.lb_filtername.Text = "Filter 1";
            this.lb_filtername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_filterimage
            // 
            this.pb_filterimage.BackColor = System.Drawing.Color.Silver;
            this.pb_filterimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_filterimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_filterimage.Location = new System.Drawing.Point(24, 4);
            this.pb_filterimage.Name = "pb_filterimage";
            this.pb_filterimage.Size = new System.Drawing.Size(113, 113);
            this.pb_filterimage.TabIndex = 2;
            this.pb_filterimage.TabStop = false;
            // 
            // FilterPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.lb_filtername);
            this.Controls.Add(this.pb_filterimage);
            this.Name = "FilterPanel";
            this.Size = new System.Drawing.Size(160, 171);
            ((System.ComponentModel.ISupportInitialize)(this.pb_filterimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_filtername;
        private System.Windows.Forms.PictureBox pb_filterimage;
    }
}
