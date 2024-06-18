using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.SQLConnection;

namespace CapaDatos.Metodos
{
    public class DIngreso: ClassConnection
    {

        //Metodo que muestra los ingresos en el datagrid
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
    }
}
