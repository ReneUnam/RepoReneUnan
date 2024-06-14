using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    //Utilizamos una clase cache en una capa comun para el almacenamiento de datos temporales.
    public static class UserCache
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string Contraseña { get; set; }
        public static int Telefono { get; set; }
        public static string Correo { get; set; }
        public static int IdRoles { get; set; }
        public static byte[] ImagenUsuario { get; set; }
    }
}
