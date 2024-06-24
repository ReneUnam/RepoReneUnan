using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmOscuro : Form
    {
        public FrmOscuro()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        public void Mostrar()
        {
            this.Show(); // Mostrar el formulario de fondo oscuro
        }

        public void Ocultar()
        {
            this.Hide(); // Ocultar el formulario de fondo oscuro
        }
    }
}
