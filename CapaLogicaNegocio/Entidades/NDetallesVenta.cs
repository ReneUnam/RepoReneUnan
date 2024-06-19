using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
using CapaDatos.Metodos;
using System.Data;

namespace CapaLogicaNegocio.Entidades
{
    public class NDetallesVenta
    {
        DetallesVenta ObjetoD = new DetallesVenta();

        public DataTable MostrarDetallesVenta()
        {
            return new DetallesVenta().MostrarDetallesVenta();
        }
    }
}
