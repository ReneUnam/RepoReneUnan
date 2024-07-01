using CapaLogicaNegocio.Entidades;
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
    public partial class frmComprasHistorial : Form
    {
        public frmComprasHistorial()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmComprasHistorial_Load(object sender, EventArgs e)
        {
           dgvIngresos.DataSource = new NIngreso().MostrarIngresos();
        }
    }
}
