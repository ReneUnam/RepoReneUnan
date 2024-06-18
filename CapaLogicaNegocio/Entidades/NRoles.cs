using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaDatos.Metodos;
using CapaComun.Cache;

namespace CapaLogicaNegocio.Entidades
{
    public class NRoles
    {
        private DRoles RCD = new DRoles();

        public DataTable MostrarRoles()
        {
            DataTable tabla = new DataTable();
            tabla = RCD.Mostrar();
            return tabla;

        }
    }
}
