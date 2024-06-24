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
    public class DUsuario : ClassConnection
    {
        // Propiedades
        private int _IdUsuario;
        private string _Nombre;
        private string _Apellido;
        private string _Contraseña;
        private int _Telefeno;
        private string _Correo;
        private int _IdRoles;

        //Atributos 
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public int Telefeno { get => _Telefeno; set => _Telefeno = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public int IdRoles { get => _IdRoles; set => _IdRoles = value; }

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
                        while (reader.Read())
                        {
                            UserCache.IdUsuario = reader.GetInt32(0);
                            UserCache.Nombre = reader.GetString(1);
                            UserCache.Apellido = reader.GetString(2);
                            UserCache.Correo = reader.GetString(5);
                            UserCache.IdRoles = reader.GetInt32(6);
                        }

                        return true;
                    }
                    else return false;
                }
            }
        }

        public DataTable MostrarUsuarios()
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                DataTable dtResultado = new DataTable("Usuarios");

                using (var Command = new SqlCommand())
                {
                    Command.Connection = Connection;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "SpMostrarUsuarios";

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

        public DataTable MostrarAdmins()
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                DataTable dtResultado = new DataTable("Admins");

                using (var Command = new SqlCommand())
                {
                    Command.Connection = Connection;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "Sp_MostrarAdmins";

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
