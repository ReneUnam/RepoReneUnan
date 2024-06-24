using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos.SQLConnection;

namespace CapaDatos.Metodos
{
    public class DProducto: ClassConnection
    {
        //Propiedades
        private int _Id_Productos;
        private string _Nombre;
        private string _Descripcion;
        private int _IdCategoria;
        private float _PrecioVenta;
        private int _Stock;
        private DateTime _Fecha_Vencimiento;
     

        //Atributos
        public int idProductos { get => _Id_Productos; set => _Id_Productos = value; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int IdCategoria { get; set; }

        public double PrecioVenta { get; set; }

        public int Stock { get; set; }

        public DateTime FechaVencimiento { get; set; }



        public DataTable MostrarProductos()
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                DataTable dtResultado = new DataTable("Productos");

                using (var Command = new SqlCommand())
                {
                    Command.Connection = Connection;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "spmostrar_Productos";

                    try
                    {
                        SqlDataAdapter SqlDat = new SqlDataAdapter(Command);
                        SqlDat.Fill(dtResultado);
                    }
                    catch (Exception ex)
                    {
                        // Log the exception or handle it as necessary (modo duolingo)
                        Console.WriteLine("Error: " + ex.Message);
                        dtResultado = null;
                    }
                }

                return dtResultado;
            }
        }

        public string Insertar(DProducto producto)
        {
            string rpta = "";
            SqlConnection connection = GetConnection();

            try
            {
                connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandText = "spInsertar_Productos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@Id_Productos";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdProducto);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = producto.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 1024;
                ParDescripcion.Value = producto.Descripcion;
                sqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@IdCategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = producto.IdCategoria;
                sqlCmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParPrecVenta = new SqlParameter();
                ParPrecVenta.ParameterName = "@PrecioVenta";
                ParPrecVenta.SqlDbType = SqlDbType.Int;
                ParPrecVenta.Value = producto.PrecioVenta;
                sqlCmd.Parameters.Add(ParPrecVenta);

                SqlParameter ParStock = new SqlParameter();
                ParStock.ParameterName = "@Stock";
                ParStock.SqlDbType = SqlDbType.Int;
                ParStock.Value = producto.Stock;
                sqlCmd.Parameters.Add(ParStock);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha_vencimiento";
                ParFecha.SqlDbType = SqlDbType.Int;
                ParFecha.Value = producto.FechaVencimiento;
                sqlCmd.Parameters.Add(ParFecha);


                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Ingreso el Reistro";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }

            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return rpta;
        }

        public string SumarStock(int idproducto, int cantidad)
        {
            string rpta = "";
            string procedimientoAlmacenado = "SumarStockProducto";
            SqlConnection connection = GetConnection();
            using (SqlCommand command = new SqlCommand(procedimientoAlmacenado, connection))
            {
                try
                {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                command.Parameters.Add(new SqlParameter("@ProductoID", SqlDbType.Int)).Value = idproducto; // Ejemplo de ProductoID
                command.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int)).Value = cantidad; // Ejemplo de Cantidad

                // Ejecutar el comando
                int rowsAffected = command.ExecuteNonQuery();


                }
                catch (Exception ex)
                {

                    rpta = ex.Message;
                }

                finally
                {
                    if (connection.State == ConnectionState.Open) connection.Close();
                }

                return rpta;
            }
        }


    }
}
