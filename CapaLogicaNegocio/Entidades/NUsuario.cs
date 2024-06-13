using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaLogicaNegocio.Entidades
{
    internal class NUsuario
    {
        private int idUsuario { get; set; }
        public int NombreUsuario { get; set; }
        public int Contrasena { get; set; }
        public int Telefono { get; set; }
        public int Correo { get; set; }
        public int IdRoles { get; set; }

        public void iniciarSesion()
        {
            

        }
        
    }
}
