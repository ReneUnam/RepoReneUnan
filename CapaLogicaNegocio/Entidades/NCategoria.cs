using CapaDatos.Metodos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Entidades
{
    public class NCategoria
    {
        public DataTable ListarCategorias() => new DCategoria().ListarCategoria();
    }
}
