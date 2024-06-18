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
    }
}
