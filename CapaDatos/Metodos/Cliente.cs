using CapaDatos.SQLConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Metodos
{
    public class Cliente: ClassConnection
    {
        public int Id_Cliente { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; } 
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}
