using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos.SQLConnection;
using System.Data;
using CapaComun.Cache;

namespace CapaDatos.Metodos
{
    public class DUsuario:ClassConnection
    {
        // Propiedades
        private int _IdUsuario;
        private string _NombreUsuario;
        private string _Contraseña;
        private int _Telefono;
        private string _Correo;
        private int _IdRoles;
        private byte[] _imagenUsuario;

        //Atributos 
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string Contraseña { get => _Contraseña; set => Contraseña = value; }
        public int Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public int IdRoles { get; set; }
        public byte[] ImagenUsuario { get; set; }

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

                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            UserCache.IdUsuario = reader.GetInt32(0);
                            UserCache.NombreUsuario = reader.GetString(1);
                            UserCache.Correo = reader.GetString(4);
                            UserCache.IdRoles = reader.GetInt32(5);
                        }

                        return true;
                    }
                        

                    else return false;

                }
            }
        }
    } 
}
