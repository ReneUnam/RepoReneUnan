using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Entidades
{
    internal class NProducto
    {
        public int idProductos { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int IdCategoria { get; set;}

        public double PrecioVenta { get; set;}

        public int Stock { get; set;}

        public DateTime FechaVencimiento { get; set; }

    }
}
