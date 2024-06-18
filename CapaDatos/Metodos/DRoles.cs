using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos.SQLConnection;


namespace CapaDatos.Metodos
{
    public class DRoles:ClassConnection
    {
        private int _IdRoles;
        private string _NombreDelRol;
        private string _Descripcion;

        public int IdRoles { get => _IdRoles; set => _IdRoles = value; }
        public string NombreDelRol { get => _NombreDelRol; set => _NombreDelRol = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        /*
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    comando.CommandText = "SpMostrarRoles";
                    comando.CommandType = CommandType.StoredProcedure;
                    leer = comando.ExecuteReader();
                    tabla.Load(leer);

                    return tabla;

                }

            }
        }
        */

        public DataTable MostrarRoles()
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                DataTable dtResultado = new DataTable("Roles");

                using (var Command = new SqlCommand())
                {
                    Command.Connection = Connection;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "SpMostrarRoles";

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
