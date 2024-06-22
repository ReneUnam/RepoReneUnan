using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio.Entidades;

namespace CapaPresentacion
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListado.DataSource = new NIngreso().MostrarIngresos();
            //Totalizar los registros
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvListado.Rows.Count);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
