using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaDatos.Metodos;

namespace CapaLogicaNegocio.Entidades
{
    public class NProducto
    {
        public DataTable MostrarProductos()
        {

            return new DProducto().MostrarProductos();
        }

        public static string Insertar(string nombre, string descripcion, int categoria, int precioVenta, DateTime fecha, int stock)
        {
            DProducto objProducto = new DProducto();

            objProducto.Nombre = nombre;
            objProducto.Descripcion = descripcion;
            objProducto.IdCategoria = categoria;
            objProducto.PrecioVenta = precioVenta;
            objProducto.FechaVencimiento = fecha;
            objProducto.Stock = stock;

            return objProducto.Insertar(objProducto);
        }

        public static string SumarStock(int idproducto, int cantidad)
        {
            string rpta = "";

            new DProducto().SumarStock(idproducto, cantidad);

            return rpta;
        }
        public static DataTable BuscarNombre(string textobuscar)
        {
            DProducto objProducto = new DProducto();
            objProducto.TextoBuscar = textobuscar;
            return objProducto.BuscarProducto(objProducto);

        }

    }  
}
