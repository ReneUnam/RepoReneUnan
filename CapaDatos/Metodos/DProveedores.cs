using CapaDatos.SQLConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Metodos
{
    public class DProveedores: ClassConnection
    {
        //Metodo que utilizaremos para mostrar los proveedores en el comboBox
        public DataTable ListarProveedores()
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;
                command.Connection = connection;
                command.CommandText = "Sp_ListarProveedores";
                command.CommandType = CommandType.StoredProcedure;
                reader = command.ExecuteReader();
                table.Load(reader);
                reader.Close();
            }

            return table;
        }
    }
}
