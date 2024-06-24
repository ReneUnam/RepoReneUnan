using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.SQLConnection;
using System.Data.SqlTypes;

namespace CapaDatos.Metodos
{
    public class DDetalleIngreso: ClassConnection
    {
        //propiedades
        private int _Id_DetalleIngreso;
        private int _Cantidad;
        private int _PrecioUnitario;
        private double _SubTotal;
        private int _Id_Producto;
        private int _Id_Ingreso;
        private int _PrecioVenta;
        private int _stock;

        //Atributos
        public int Id_DetalleIngreso { get => _Id_DetalleIngreso; set=> _Id_DetalleIngreso = value; }
        public int Cantidad { get => _Cantidad; set=> _Cantidad = value;}
        public int PrecioUnitario { get => _PrecioUnitario; set=> _PrecioUnitario = value;}
        public double SubTotal { get=> _SubTotal; set=> _SubTotal = value;}
        public int Id_Productos { get => _Id_Producto; set => _Id_Producto = value;}
        public int Id_Ingreso { get=> _Id_Ingreso; set=> _Id_Ingreso = value;}
        public int PrecioVenta { get=> _PrecioVenta; set=> _PrecioVenta = value; }
        public int Stock { get => _stock; set=> _stock = value; }

        public string Insertar(DDetalleIngreso Detalle_Ingreso,
            ref SqlConnection sqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            using (var connetion = GetConnection()) //Palabra clave using que nos ayuda a desechar todo luego de usarlo
            { 
                connetion.Open();

                using (var command = new SqlCommand())
                {
                    try
                    {
                        //Definimos los comandos
                        command.Connection = connetion;//El de la conección para que nuestro command funcione de acuerdo a la BD    
                        command.Transaction = SqlTra;
                        command.CommandText = "Sp_InsertarDetalleIngreso";
                        command.CommandType = CommandType.StoredProcedure;

                        //Definimos los parametros para el procedimineto almacenado
                        SqlParameter ParIddetalle_Ingrso = new SqlParameter();
                        ParIddetalle_Ingrso.ParameterName = "@iddetalle_ingreso";
                        ParIddetalle_Ingrso.SqlDbType = SqlDbType.Int;
                        ParIddetalle_Ingrso.Direction = ParameterDirection.Output;
                        command.Parameters.Add(ParIddetalle_Ingrso);

                        SqlParameter ParCantidad = new SqlParameter();
                        ParCantidad.ParameterName = "@Cantidad";
                        ParCantidad.SqlDbType = SqlDbType.Int;
                        // ParIdingreso.Size = 50;
                        ParCantidad.Value = Detalle_Ingreso.Cantidad; //Le asignamos al atributo de la instancia el valor del parametro. 
                        command.Parameters.Add(ParCantidad);

                        SqlParameter ParPrecioUnitario = new SqlParameter();
                        ParPrecioUnitario.ParameterName = "@PrecioUnitario";
                        ParPrecioUnitario.SqlDbType = SqlDbType.Float;
                        // ParIdingreso.Size = 50;
                        ParPrecioUnitario.Value = Detalle_Ingreso.PrecioUnitario;
                        command.Parameters.Add(ParPrecioUnitario);


                        SqlParameter ParSubtotal = new SqlParameter();
                        ParSubtotal.ParameterName = "@subTotal";
                        ParSubtotal.SqlDbType = SqlDbType.Money;
                        //ParPrecio_Compra.Size = 256;
                        ParSubtotal.Value = Detalle_Ingreso.SubTotal;
                        command.Parameters.Add(ParSubtotal);

                        SqlParameter ParIdProductos = new SqlParameter();
                        ParIdProductos.ParameterName = "@idProductos";
                        ParIdProductos.SqlDbType = SqlDbType.Money;
                        //ParPrecio_Compra.Size = 256;
                        ParIdProductos.Value = Detalle_Ingreso.Id_Productos;
                        command.Parameters.Add(ParIdProductos);

                        SqlParameter ParIngreso = new SqlParameter();
                        ParIngreso.ParameterName = "@idIngreso";
                        ParIngreso.SqlDbType = SqlDbType.Int;
                        // ParIdingreso.Size = 50;
                        ParIngreso.Value = Detalle_Ingreso.Id_Ingreso;
                        command.Parameters.Add(ParIngreso);

                        SqlParameter ParPrecioVenta = new SqlParameter();
                        ParPrecioVenta.ParameterName = "@PrecioVenta";
                        ParPrecioVenta.SqlDbType = SqlDbType.Int;
                        // ParIdingreso.Size = 50;
                        ParPrecioVenta.Value = Detalle_Ingreso.PrecioVenta;
                        command.Parameters.Add(ParPrecioVenta);

                        SqlParameter ParStock = new SqlParameter();
                        ParStock.ParameterName = "@stock";
                        ParStock.SqlDbType = SqlDbType.Int;
                        // ParIdingreso.Size = 50;
                        ParStock.Value = Detalle_Ingreso.Stock;
                        command.Parameters.Add(ParStock);


                        rpta = command.ExecuteNonQuery() == 1 ? "Ok" : "No se Ingreso el Reistro";
                    }
                    catch (Exception ex)
                    {

                        rpta = ex.Message;
                    }

                    return rpta;
                }

            }
           
        }
       
    }
}
