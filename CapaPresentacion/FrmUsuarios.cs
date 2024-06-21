using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;
using CapaLogicaNegocio.Entidades;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios()
        {
            NUsuario MCP = new NUsuario();
            dgvUsuarios.DataSource = MCP.MostrarUsuarios();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
