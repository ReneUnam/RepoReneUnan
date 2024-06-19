using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaDatos.SQLConnection;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaComun.Cache;


namespace CapaDatos.Metodos
{
    public class DetallesVenta : ClassConnection
    {
        private int _IdDetallesVenta;
        private int _Cantidad;
        private int _PrecioUnitario;
        private SqlMoney _Total;
        private int _Id_Productos;
        private int _IdVenta;

        public int IdDetallesVenta { get => _IdDetallesVenta; set => _IdDetallesVenta = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public int PrecioUnitario { get => _PrecioUnitario; set => _PrecioUnitario = value; }
        public SqlMoney Total { get => _Total; set => _Total = value; }
        public int Id_Productos { get => _Id_Productos; set => _Id_Productos = value; }
        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }



        public DataTable MostrarDetallesVenta()
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                DataTable dtResultado = new DataTable("Ventas");

                using (var Command = new SqlCommand())
                {
                    Command.Connection = Connection;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "SpMostrarDetallesVenta";

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
