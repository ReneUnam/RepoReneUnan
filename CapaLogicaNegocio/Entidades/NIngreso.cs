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
        public static string InsertarIngreso(int idIngreso, DateTime fecha, double iva,
        double total, int idproveedor, int idUsuario, DataTable dtdetalles) //Aqui se reciben 
        {
            DIngreso objIngreso = new DIngreso();
            objIngreso.IdIngreso = idIngreso;
            objIngreso.Fecha = fecha;
            objIngreso.Iva = iva;
            objIngreso.Total = total;
            objIngreso.IdProveedor = idproveedor;
            objIngreso.IdUsuario = idUsuario;

            List<DDetalleIngreso> detalles = new List<DDetalleIngreso>();

            foreach (DataRow row in dtdetalles.Rows)
            {
                DDetalleIngreso detalle = new DDetalleIngreso();
                detalle.Id_Productos = Convert.ToInt32(row["Id_Productos"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["Cantidad"].ToString());
                detalle.PrecioUnitario = Convert.ToInt32(row["PrecioUnitario"].ToString());
                detalle.PrecioVenta = Convert.ToInt32(row["PrecioVenta"].ToString());
                detalle.Stock = Convert.ToInt32(row["Stock"].ToString());
                detalle.SubTotal = Convert.ToInt32(row["SubTotal"].ToString());

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
