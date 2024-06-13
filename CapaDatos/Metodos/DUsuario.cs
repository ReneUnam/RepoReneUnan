using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos.SQLConnection;
using System.Data;

namespace CapaDatos.Metodos
{
    public class DUsuario:ClassConnection
    {
        public bool Login(int userId, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) 
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Sp_Login";
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@pass", password);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) return true;
                    else return false;

                }
            }
        }
    } 
}
