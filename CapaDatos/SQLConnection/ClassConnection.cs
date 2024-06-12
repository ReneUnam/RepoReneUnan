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
        SqlConnection Connection = new SqlConnection("Data Source=RENEALEXANDER;Initial Catalog=VAND_y_MONTI;Integrated Security=True");
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
