using CapaDatos.Metodos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Entidades
{
    public class NProveedores
    {

        //Metodo que llama al metodo de listar proveedores de la capa datos 
        public DataTable ListarProveedores() => new DProveedores().ListarProveedores();
    
    }
}
