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
                // Obtener el formulario actual en el panel
                Form formularioAnterior = this.panelPrincipal.Controls[0] as Form;

                // Eliminar el formulario actual del panel
                this.panelPrincipal.Controls.RemoveAt(0);

                // Liberar los recursos del formulario anterior
                if (formularioAnterior != null)
                {
                    formularioAnterior.Dispose(); // Liberar recursos
                }
            }

            // Agregar el nuevo formulario al panel
            Form form1 = form as Form;
            if (form1 != null)
            {
                form1.TopLevel = false; // Decir que no es un formulario de nivel superior
                form1.Dock = DockStyle.Fill; // Hace que se acople al panel contenedor
                this.panelPrincipal.Controls.Add(form1);
                this.panelPrincipal.Tag = form1;
                form1.Show();
            }
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
