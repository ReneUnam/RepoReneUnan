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

    }
}
