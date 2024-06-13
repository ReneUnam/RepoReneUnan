using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Entidades
{
    internal class NFactura
    {
        private int idFactura { get; set; }

        public string NombreUsuario { get; set;}

        public DateTime Fecha { get; set;}

        public double Iva { get; set;}

        public double Total { get; set;}

        public int idUsuario { get; set;}

        public int idProveedor { get; set;}
    }
}
