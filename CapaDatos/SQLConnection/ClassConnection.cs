using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos.SQLConnection
{
     public abstract class ClassConnection
    {
        private readonly string ConnectionToString;

        public ClassConnection()
        {
            //NOTA: Si van a cambiar a su base de dato simplemente copien y peguen aquí.
            ConnectionToString = ("Data Source=ReneAlexander\\SQLEXPRESS;Initial Catalog=Vand_Y_Monti;Integrated Security=True");
        }
        protected SqlConnection GetConnection() 
        {
            return new SqlConnection(ConnectionToString);
        }
        //  (Rene) 
        //static public SqlConnection Connection = new SqlConnection("Data Source=ReneAlexander\SQLEXPRESS;Initial Catalog=Vand_Y_Monti;Integrated Security=True");

        //Gary Guapo
        //SqlConnection Connection = new SqlConnection("Data Source=GARY\\MYSQL;Initial Catalog=Vand_Y_Monti;Integrated Security=True;TrustServerCertificate=True");

        //kenner
        //Data Source=DESKTOP-69623FA;Initial Catalog=Vand_Y_Monti;Integrated Security=True;Encrypt=True;TrustServerCertificate=True

        //omar
        //Data Source=ALLISON1822\SQLEXPRESS;Initial Catalog=Vand_Y_Monti;Integrated Security=True;TrustServerCertificate=True
    }
}
