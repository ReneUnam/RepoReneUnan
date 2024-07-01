using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Metodos;

namespace CapaLogicaNegocio.Entidades
{
    public class NIngreso
    {
        //Metodo para insertar datos en la BD
        public static string InsertarIngreso(int idUsuario, DateTime fecha, double iva,
        double total, int idproveedor, DataTable dtdetalles) //Aqui se reciben 
        {
            float fIva = (float)iva; //convertimos de double a float
            DIngreso objIngreso = new DIngreso();
            objIngreso.IdUsuario = idUsuario;
            objIngreso.Fecha = fecha;
            objIngreso.Iva = fIva;
            objIngreso.Total = total;
            objIngreso.IdProveedor = idproveedor;
  

            List<DDetalleIngreso> detalles = new List<DDetalleIngreso>();

            foreach (DataRow row in dtdetalles.Rows)
            {
                
                DDetalleIngreso detalle = new DDetalleIngreso();
                detalle.Id_Productos = Convert.ToInt32(row["ID"].ToString());
                //producto
                detalle.PrecioUnitario = Convert.ToInt32(row["Precio Compra"].ToString());
                detalle.PrecioVenta = Convert.ToInt32(row["Precio Venta"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["Cantidad"].ToString());
                //descripcion
                //detalle.Stock = Convert.ToInt32(row["Stock"].ToString());
                detalle.SubTotal = Convert.ToInt32(row["SubTotal"].ToString());
                //tipo
                detalles.Add(detalle);
            }

            return objIngreso.InsertarIngreso(objIngreso, detalles);
        }

        //Metodo que muestra los ingresos en la datagrid
        public DataTable MostrarIngresos()
        {
            return new DIngreso().MostrarIngresos();
        }

        public static string Eliminar(int idingreso)
        {
            DIngreso objIngreso = new DIngreso();
            objIngreso.IdIngreso = idingreso;

            return objIngreso.Eliminar(objIngreso);
        }

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DIngreso objIngreso = new DIngreso();

            return objIngreso.BuscarFecha(textobuscar, textobuscar2);
        }


    }
}
