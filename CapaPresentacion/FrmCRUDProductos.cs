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
    public partial class FrmCRUDproductos : Form
    {
        public FrmCRUDproductos()
        {
            InitializeComponent();
        }

        private void FrmCRUDproductos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el texto a buscar
          /*  string textoABuscar = textBuscar.Text.ToLower(); // Convertir a minúsculas para una búsqueda sin distinción de mayúsculas/minúsculas

            // Filtrar la DataGridView
            var filasFiltradas = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(fila =>
                    fila.Cells["Nombre"].Value != null && fila.Cells["Nombre"].Value.ToString().ToLower().Contains(textoABuscar) ||
                    fila.Cells["Descripción"].Value != null && fila.Cells["Descripción"].Value.ToString().ToLower().Contains(textoABuscar))
                .ToList();

            // Mostrar resultados
            dataGridView1.DataSource = null; // Limpiar DataSource previo
            dataGridView1.Rows.Clear(); // Limpiar filas previas si es necesario
            foreach (DataGridViewRow fila in filasFiltradas)
            {
                dataGridView1.Rows.Add(fila); // Agregar las filas filtradas al DataGridView
            }*/
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            // Obtener el texto a buscar
            string textoABuscar = textBuscar.Text.ToLower(); // Convertir a minúsculas para una búsqueda sin distinción de mayúsculas/minúsculas

            // Filtrar la DataGridView
            var filasFiltradas = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(fila =>
                    fila.Cells["Nombre"].Value != null && fila.Cells["Nombre"].Value.ToString().ToLower().Contains(textoABuscar) ||
                    fila.Cells["Descripción"].Value != null && fila.Cells["Descripción"].Value.ToString().ToLower().Contains(textoABuscar))
                .ToList();

            // Mostrar resultados
            dataGridView1.DataSource = null; // Limpiar DataSource previo
            dataGridView1.Rows.Clear(); // Limpiar filas previas si es necesario
            foreach (DataGridViewRow fila in filasFiltradas)
            {
                dataGridView1.Rows.Add(fila); // Agregar las filas filtradas al DataGridView
            }
        }
    }
}
