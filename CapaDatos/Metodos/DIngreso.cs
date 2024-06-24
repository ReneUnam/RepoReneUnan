using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.SQLConnection;

namespace CapaDatos.Metodos
{
    public class DIngreso: ClassConnection
    {
        //Atributos 
        private int _id_Ingreso;
        private DateTime _fecha;
        private double _iva;
        private double _total;
        private int _id_Proveedor;
        private int _id_Usuario;

        //Propiedades
        public int IdIngreso { get=> _id_Ingreso; set=> _id_Ingreso = value; }
        public DateTime Fecha { get=> _fecha; set=> _fecha = value; }
        public double Iva { get => _iva; set=> _iva =value; }
        public double Total { get => _total; set=> _total = value; }
        public int IdProveedor { get=> _id_Proveedor; set=> _id_Proveedor = value; }
        public int IdUsuario { get=> -_id_Usuario; set=> _id_Usuario = value; }
        
        public string InsertarIngreso(DIngreso Ingreso, List<DDetalleIngreso> Detalle)
        {
            string rpta = "";
            using (var command = new SqlCommand())
            {
                SqlConnection connection = new SqlConnection();
                try
                {
                    connection = GetConnection();
                    connection.Open();
                    //Establecemos la transaccion la cual nos ayudara a no romper la base de datos en caso de una cagada
                    SqlTransaction sqlTra = connection.BeginTransaction();
                    command.Transaction = sqlTra;
                    command.CommandText = "Sp_InsertarIngreso";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter ParIdIngreso = new SqlParameter();
                    ParIdIngreso.ParameterName = "@idingreso";
                    ParIdIngreso.SqlDbType = SqlDbType.Int;
                    ParIdIngreso.Direction = ParameterDirection.Output;
                    command.Parameters.Add(ParIdIngreso);

                    SqlParameter ParFecha = new SqlParameter();
                    ParFecha.ParameterName = "@fecha";
                    ParFecha.SqlDbType = SqlDbType.Date;
                    ParFecha.Value = Ingreso.Fecha;
                    command.Parameters.Add(ParFecha);

                    SqlParameter ParIva = new SqlParameter();
                    ParIva.ParameterName = "@iva";
                    ParIva.SqlDbType = SqlDbType.Float;
                    ParIva.Value = Ingreso.Iva;
                    command.Parameters.Add(ParIva);

                    SqlParameter ParTotal = new SqlParameter();
                    ParFecha.ParameterName = "@total";
                    ParFecha.SqlDbType = SqlDbType.Money;
                    //ParFecha.Size = 50;
                    ParFecha.Value = Ingreso.Fecha;
                    command.Parameters.Add(ParFecha);

                    SqlParameter ParIdProveedor = new SqlParameter();
                    ParIdProveedor.ParameterName = "@idProveedor";
                    ParIdProveedor.SqlDbType = SqlDbType.Int;
                    ParIdProveedor.Size = 20;
                    ParIdProveedor.Value = Ingreso.IdProveedor;
                    command.Parameters.Add(ParIdProveedor);

                    SqlParameter ParIdUsuario = new SqlParameter();
                    ParIdUsuario.ParameterName = "@idUsuario";
                    ParIdUsuario.SqlDbType = SqlDbType.Int;
                    ParIdUsuario.Size = 4;
                    ParIdUsuario.Value = Ingreso.IdUsuario;
                    command.Parameters.Add(ParIdUsuario);

                    rpta = command.ExecuteNonQuery() == 1 ? "Ok" : "No se Ingreso el Reistro";

                    if (rpta.Equals("Ok"))
                    {
                        this.IdIngreso = Convert.ToInt32(command.Parameters["@idingreso"].Value);

                        foreach (DDetalleIngreso det in Detalle)
                        {
                            det.Id_Ingreso = this.IdIngreso;
                            //llamar al método insertar de la clase Detalle_Ingreso
                            rpta = det.Insertar(det, ref connection, ref sqlTra);
                            if (!rpta.Equals("Ok"))
                            {
                                break;
                            }
                        }
                    }
                    if (rpta.Equals("Ok"))
                    {
                        sqlTra.Commit();
                    }
                    else
                    {
                        sqlTra.Rollback();
                    }
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
        

        //Metodo que muestra los ingresos en el datagrid //TODOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        public DataTable MostrarIngresos() 
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                DataTable dtResultado = new DataTable("Ingresos");

                using (var Command = new SqlCommand())
                {
                    Command.Connection = Connection;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "Sp_MostrarCompras";

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

        
        public string Eliminar(DIngreso Ingreso)
        {
            string rpta = "";
            SqlConnection connection = new SqlConnection();
            try
            {
                connection = GetConnection();
                connection.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandText = "Sp_EliminarIngreso";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idingreso";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Value = Ingreso.IdIngreso; //de entrada
                sqlCmd.Parameters.Add(ParIdingreso);

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Anulo el Reistro";
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

        public DataTable BuscarFecha(String TextoBuscar, string TextoBuscar2)
        {
            DataTable dtResultado = new DataTable("ingreso");
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {   
                    SqlCommand Sqlcmd = new SqlCommand();
                    Sqlcmd.Connection = connection;
                    Sqlcmd.CommandText = "Sp_BuscarPorFecha";
                    Sqlcmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter PartextoBuscar = new SqlParameter();
                    PartextoBuscar.ParameterName = "@textobuscar";
                    PartextoBuscar.SqlDbType = SqlDbType.VarChar;
                    PartextoBuscar.Size = 20;
                    PartextoBuscar.Value = TextoBuscar;
                    Sqlcmd.Parameters.Add(PartextoBuscar);

                    SqlParameter PartextoBuscar2 = new SqlParameter();
                    PartextoBuscar2.ParameterName = "@textobuscar2";
                    PartextoBuscar2.SqlDbType = SqlDbType.VarChar;
                    PartextoBuscar2.Size = 20;
                    PartextoBuscar2.Value = TextoBuscar2;
                    Sqlcmd.Parameters.Add(PartextoBuscar2);

                    SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                    SqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    dtResultado = null;
                }
                return dtResultado;
            }
        }
    }

}
