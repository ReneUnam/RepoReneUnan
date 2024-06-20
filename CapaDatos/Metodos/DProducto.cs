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
    }
}
