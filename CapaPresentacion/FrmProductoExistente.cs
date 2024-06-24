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
    public partial class FrmProductoExistente : Form
    {
        public FrmProductoExistente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOscuro frmOscuro = new FrmOscuro();
            frmOscuro.Close();
            this.Close();
        }

        private void FrmProductoExistente_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        public void MostrarProductos()
        {
            NProducto producto = new NProducto();
            dtProductos.DataSource = producto.MostrarProductos();
            dtProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
    }
}
