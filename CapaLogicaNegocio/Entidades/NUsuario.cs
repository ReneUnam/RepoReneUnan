using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
using CapaDatos.Metodos; //Referenciamos a la carpeta de metodos de la capa de datos.

namespace CapaLogicaNegocio.Entidades
{
    public class NUsuario
    {
        private int idUsuario { get; set; }
        public int NombreUsuario { get; set; }
        public int Contrasena { get; set; }
        public int Telefono { get; set; }
        public int Correo { get; set; }
        public int IdRoles { get; set; }

        DUsuario dUsuario = new DUsuario();

        public bool Login(int userId, string pass) => dUsuario.Login(userId, pass);
    }
}
