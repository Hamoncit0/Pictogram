namespace Pictogram
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btn_video = new System.Windows.Forms.Button();
            this.btn_foto = new System.Windows.Forms.Button();
            this.btn_camara = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(78)))), ((int)(((byte)(173)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btn_video);
            this.panelMenu.Controls.Add(this.btn_foto);
            this.panelMenu.Controls.Add(this.btn_camara);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(163, 634);
            this.panelMenu.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(163, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(924, 634);
            this.panelPrincipal.TabIndex = 1;
            // 
            // btn_video
            // 
            this.btn_video.BackgroundImage = global::Pictogram.Properties.Resources.Video;
            this.btn_video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_video.FlatAppearance.BorderSize = 0;
            this.btn_video.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(209)))));
            this.btn_video.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(138)))));
            this.btn_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_video.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_video.Location = new System.Drawing.Point(0, 192);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(160, 165);
            this.btn_video.TabIndex = 1;
            this.btn_video.UseVisualStyleBackColor = true;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click);
            // 
            // btn_foto
            // 
            this.btn_foto.BackgroundImage = global::Pictogram.Properties.Resources.Image__1_;
            this.btn_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_foto.FlatAppearance.BorderSize = 0;
            this.btn_foto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(209)))));
            this.btn_foto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(138)))));
            this.btn_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_foto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_foto.Location = new System.Drawing.Point(0, 21);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(160, 165);
            this.btn_foto.TabIndex = 0;
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // btn_camara
            // 
            this.btn_camara.BackgroundImage = global::Pictogram.Properties.Resources.Camera;
            this.btn_camara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_camara.FlatAppearance.BorderSize = 0;
            this.btn_camara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(209)))));
            this.btn_camara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(138)))));
            this.btn_camara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_camara.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_camara.Location = new System.Drawing.Point(0, 363);
            this.btn_camara.Name = "btn_camara";
            this.btn_camara.Size = new System.Drawing.Size(160, 165);
            this.btn_camara.TabIndex = 2;
            this.btn_camara.UseVisualStyleBackColor = true;
            this.btn_camara.Click += new System.EventHandler(this.btn_camara_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Pictogram.Properties.Resources.Group_2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(209)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(138)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 100);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1087, 634);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Pictogram";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Button btn_camara;
        private System.Windows.Forms.Button btn_video;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button button1;
    }
}

