using Pictogram.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pictogram
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //abre el form que se le manda en el object
        public void abrirEnPnlPrincipal(object form)
        {
            if (this.panelPrincipal.Controls.Count > 0)
            {
                //Elimina lo que este dentro del contenedor si es que hay algo :)
                this.panelPrincipal.Controls.RemoveAt(0);
            }
            Form form1 = form as Form;
            form1.TopLevel = false; //decir que no es un formulario de nivel superior
            form1.Dock = DockStyle.Fill; //hace que se acople al panel contenedor
            this.panelPrincipal.Controls.Add(form1);
            this.panelPrincipal.Tag = form1;
            form1.Show();
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            abrirEnPnlPrincipal(new Fotos());
        }

        private void btn_video_Click(object sender, EventArgs e)
        {
            abrirEnPnlPrincipal(new Video());
        }

        private void btn_camara_Click(object sender, EventArgs e)
        {
            abrirEnPnlPrincipal(new Camara());
        }
    }
}
