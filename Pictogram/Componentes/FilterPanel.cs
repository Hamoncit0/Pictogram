using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pictogram.Componentes
{
    public partial class FilterPanel : UserControl
    {
        public event EventHandler FilterClicked;
        public string FilterName
        {
            get => lb_filtername.Text;
            set => lb_filtername.Text = value;
        }

        public Image FilterImage
        {
            get => pb_filterimage.Image;
            set => pb_filterimage.Image = value;
        }

        public FilterPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.None;
            pb_filterimage.Click += (s, e) => FilterClicked?.Invoke(this, EventArgs.Empty);
            lb_filtername.Click += (s, e) => FilterClicked?.Invoke(this, EventArgs.Empty);
            this.Click += (s, e) => FilterClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
