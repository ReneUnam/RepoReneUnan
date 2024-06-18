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
        public DataTable MostrarRoles()
        {
          
           return new DRoles().MostrarRoles();
        }
    }
}
