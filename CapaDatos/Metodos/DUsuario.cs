using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos.SQLConnection;
using System.Data;
using CapaComun.Cache;
using System.Data.SqlTypes;

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
        private string _TBuscar;

        //Atributos 
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public int Telefeno { get => _Telefeno; set => _Telefeno = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public int IdRoles { get => _IdRoles; set => _IdRoles = value; }
        public string TBuscar { get => _TBuscar; set => _TBuscar = value; }

        

        //Constructores
        public DUsuario()
        {
           
        }

        public DUsuario( string nombre, string apellido, string contraseña, int telefeno, string correo, int idRoles)
        {
           // this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Contraseña = contraseña;
            this.Telefeno = telefeno;
            this.Correo = correo;
            this.IdRoles = idRoles;
        }


      
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

      
        public string InsertarUsuario(DUsuario usuario)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            using (var Connection = GetConnection()) //Error es porque en ningun momento le pasamos la cadena de conexion al command segun decía
            {
                Connection.Open();
                using (var Command = new SqlCommand()) //Este que tenes aquí
                {
                    SqlCommand sqlCmd = new SqlCommand(); //es lo mismo que este

                    try
                    {
                        Command.Connection = Connection; //Aqui el command recibe la cadena de conexion
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.CommandText = "SpCrearUsuario";

                        /*SqlParameter ParIdUsuario = new SqlParameter();
                        ParIdUsuario.ParameterName = "@id_Usuario";
                        ParIdUsuario.SqlDbType = SqlDbType.Int;
                        ParIdUsuario.Direction = ParameterDirection.Output;
                        sqlCmd.Parameters.Add(ParIdUsuario);*/

                        SqlParameter ParNombre = new SqlParameter();
                        ParNombre.ParameterName = "@Nombre";
                        ParNombre.SqlDbType = SqlDbType.VarChar;
                        ParNombre.Size = 50;
                        ParNombre.Value = usuario.Nombre;
                        Command.Parameters.Add(ParNombre);

                        SqlParameter ParApellido = new SqlParameter();
                        ParApellido.ParameterName = "@Apellido";
                        ParApellido.SqlDbType = SqlDbType.VarChar;
                        ParApellido.Size = 50;
                        ParApellido.Value = usuario.Apellido;
                        Command.Parameters.Add(ParApellido);

                        SqlParameter ParContraseña = new SqlParameter();                       
                        ParContraseña.ParameterName = "@Contrasena";
                        ParContraseña.SqlDbType = SqlDbType.VarChar;
                        ParContraseña.Size = 30;
                        ParContraseña.Value = usuario.Contraseña;
                        Command.Parameters.Add(ParContraseña);

                        SqlParameter ParTelefono = new SqlParameter();
                        ParTelefono.ParameterName = "@Telefeno";
                        ParTelefono.SqlDbType = SqlDbType.Int;
                        ParTelefono.Value = usuario.Telefeno;
                        //ParTelefono.Direction = ParameterDirection.Output; //Aquí hay que tener cuidado, los parámetros de salida son los que desde el SP lo genera el Sql
                        //entonces aqui no va esta propiedad, esto se hace solo para los parámetros de salida que en el SP se especifico cual es de salida.
                        Command.Parameters.Add(ParTelefono);

                        SqlParameter ParCorreo = new SqlParameter();
                        ParCorreo.ParameterName = "@Correo";
                        ParCorreo.SqlDbType = SqlDbType.VarChar;
                        ParCorreo.Size = 80;
                        ParCorreo.Value = usuario.Correo;
                        Command.Parameters.Add(ParCorreo);

                        SqlParameter ParIdRoles = new SqlParameter(); 
                        ParIdRoles.ParameterName = "@IdRoles"; //Corregis luego, porque daria error
                        ParIdRoles.SqlDbType = SqlDbType.Int;
                        ParIdRoles.Value = usuario.IdRoles;
                        Command.Parameters.Add(ParIdRoles);

                        //Si se ejecuta correctamente y es igual a 1 registro afectado, en caso verdadero envia un ok en string, caso contrario no se ingreso
                        //la variable rpta es de tipo estring espera lo que devuelve este condicional, es como un if pero más elegante.
                        rpta = Command.ExecuteNonQuery() == 1 ? "Ok" : "No se Ingreso el Reistro"; //aQUI sqlCmd, no es, aquí es command, porque ese si recibe la cadena
                    }
                    catch (Exception ex)
                    {

                        rpta = ex.Message;
                    } 

                    finally
                    {
                        //Si todo es correcto cierra la conexion
                        if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                    }
                    //Este metodo espera un retorno de string y aqui esta representado. todo ok, por este lado.
                    return rpta;
                    

                }
            }
        }

        public DataTable BuscarUsuario(DUsuario usuario)
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                DataTable dtResultado = new DataTable("Usuario");

                using (var Command = new SqlCommand())
                {
                    try
                    {
                        Command.Connection = Connection; 
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.CommandText = "SpBuscarUsuarios";

                        SqlParameter ParBuscar = new SqlParameter();
                        ParBuscar.ParameterName = "@filtro";
                        ParBuscar.SqlDbType = SqlDbType.NVarChar;
                        ParBuscar.Size = 100;
                        ParBuscar.Value = usuario.TBuscar;
                        Command.Parameters.Add(ParBuscar);

                        SqlDataAdapter sqldat = new SqlDataAdapter(Command);
                        sqldat.Fill(dtResultado);
                    }
                    catch (Exception)
                    {
                        dtResultado = null;
                    }
                    return dtResultado;

                }

            }
        }

        public string EliminarUsuario (DUsuario usuario)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            using (var Connection = GetConnection())
            {
                Connection.Open();
                using (var Command = new SqlCommand())
                {
                    try
                    {
                        Command.Connection = Connection;
                        Command.Connection = sqlCon;
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.CommandText = "EliminarUsuario";

                        SqlParameter ParIdUsuario = new SqlParameter();
                        ParIdUsuario.ParameterName = "@id_Usuario";
                        ParIdUsuario.SqlDbType = SqlDbType.Int;
                        ParIdUsuario.Value = usuario.IdUsuario;
                        Command.Parameters.Add(ParIdUsuario);

                        rpta = Command.ExecuteNonQuery() == 1 ? "Ok" : "No se Ingreso el Reistro";
                    }
                    catch (Exception ex)
                    {

                        rpta = ex.Message;
                    }

                    finally
                    {
                        if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                    }
                    return rpta;
                }


            }
        }

        public string EditarUsuario(DUsuario usuario)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            using (var Connection = GetConnection())
            {
                sqlCon.Open();
                using (var Command = new SqlCommand())
                {
                    try
                    {
                        Command.Connection = Connection;
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.CommandText = "SpEditarUsuario";

                        SqlParameter ParNombre = new SqlParameter();
                        ParNombre.ParameterName = "@Nombre";
                        ParNombre.SqlDbType = SqlDbType.VarChar;
                        ParNombre.Size = 50;
                        ParNombre.Value = usuario.Nombre;
                        Command.Parameters.Add(ParNombre);

                        SqlParameter ParApellido = new SqlParameter();
                        ParApellido.ParameterName = "@Apellido";
                        ParApellido.SqlDbType = SqlDbType.VarChar;
                        ParApellido.Size = 50;
                        ParApellido.Value = usuario.Apellido;
                        Command.Parameters.Add(ParApellido);

                        SqlParameter ParContraseña = new SqlParameter();
                        ParContraseña.ParameterName = "@Contrasena";
                        ParContraseña.SqlDbType = SqlDbType.VarChar;
                        ParContraseña.Size = 30;
                        ParContraseña.Value = usuario.Contraseña;
                        Command.Parameters.Add(ParContraseña);

                        SqlParameter ParTelefono = new SqlParameter();
                        ParTelefono.ParameterName = "@Telefeno";
                        ParTelefono.SqlDbType = SqlDbType.Int;
                        ParTelefono.Value = usuario.Telefeno;
                        Command.Parameters.Add(ParTelefono);

                        SqlParameter ParCorreo = new SqlParameter();
                        ParCorreo.ParameterName = "@Correo";
                        ParCorreo.SqlDbType = SqlDbType.VarChar;
                        ParCorreo.Size = 80;
                        ParCorreo.Value = usuario.Correo;
                        Command.Parameters.Add(ParCorreo);

                        SqlParameter ParIdRoles = new SqlParameter();
                        ParIdRoles.ParameterName = "@IdRoles"; 
                        ParIdRoles.SqlDbType = SqlDbType.Int;
                        ParIdRoles.Value = usuario.IdRoles;
                        Command.Parameters.Add(ParIdRoles);

                        rpta = Command.ExecuteNonQuery() == 1 ? "Ok" : "No se Ingreso el Reistro";
                    }
                    catch (Exception ex)
                    {
                        rpta = ex.Message;
                    }
                    
                    finally
                    {
                        if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                    }
                    return rpta;
                }
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
