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

        public DataTable MostrarIngresos()
        {
            return new DIngreso().MostrarIngresos();
        }
    }
}
