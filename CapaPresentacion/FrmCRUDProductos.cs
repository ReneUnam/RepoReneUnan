using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;
using CapaLogicaNegocio.Entidades;


namespace CapaPresentacion
{
    public partial class FrmCRUDproductos : Form
    {
       private SqlConnection connection;

        public FrmCRUDproductos()
        {
            InitializeComponent();
        }

        private void MostrarProductos()
        {
            NProducto PCP = new NProducto();
            dataGridView1.DataSource = PCP.MostrarProductos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }


        private void FrmCRUDproductos_Load(object sender, EventArgs e)
        {
            // cargar la tabla de datos en la DataGridView
            object dataSource = dataGridView1.DataSource;
            MostrarProductos();
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
            if (textIdProducto.Text != "" && textNombre.Text != "" && textPrecioVenta.Text != "" && dateTimePickerVencimiento.Text != "")
            {
                // Obtener los nuevos datos
                int id = Convert.ToInt32(textIdProducto.Text);
                string nombre = textNombre.Text;
                decimal precioVenta = Convert.ToDecimal(textPrecioVenta.Text);
                DateTime fechaVencimiento = Convert.ToDateTime(dateTimePickerVencimiento.Text);

                // Actualizar los datos en la tabla de datos
                string query = "UPDATE TuTabla SET Nombre = @Nombre, PrecioVenta = @PrecioVenta, FechaVencimiento = @FechaVencimiento WHERE ID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                    command.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
                    command.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos");
                    }
                }

                // Actualizar la tabla de datos en el DataGridView
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                string nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                decimal precioVenta = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["PrecioVenta"].Value);
                DateTime fechaVencimiento = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["FechaVencimiento"].Value);

                // Mostrar los datos en la caja de texto del formulario
                textIdProducto.Text = id.ToString();
                textNombre.Text = nombre;
                textPrecioVenta.Text = precioVenta.ToString();
                dateTimePickerVencimiento.Text = fechaVencimiento.ToString("yyyy-MM-dd");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
