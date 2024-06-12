using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos.SQLConnection
{
    internal class ClassConnection
    {   
        //Rene
        //SqlConnection Connection = new SqlConnection("Data Source=RENEALEXANDER;Initial Catalog=VAND_y_MONTI;Integrated Security=True");

        //Gary Guapo
        SqlConnection Connection = new SqlConnection("Data Source=GARY\\MYSQL;Initial Catalog=Vand_Y_Monti;Integrated Security=True;Trust Server Certificate=True");
        public SqlConnection OpenConnetion ()
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
            return Connection;

        }
        public SqlConnection CloseConnection()
        {
            if(Connection.State == ConnectionState.Open)
                Connection.Close();
            return Connection;
        }
    }
}
