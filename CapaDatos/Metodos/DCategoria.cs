using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.SQLConnection;

namespace CapaDatos.Metodos
{
    public class DCategoria : ClassConnection
    {
        public DataTable ListarCategoria()
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;
                command.Connection = connection;
                command.CommandText = "Sp_ListarCategorias";
                command.CommandType = CommandType.StoredProcedure;
                reader = command.ExecuteReader();
                table.Load(reader);
                reader.Close();
            }

            return table;
        }
    }
}
