using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
using CapaDatos.Metodos;
using System.Data; //Referenciamos a la carpeta de metodos de la capa de datos.

namespace CapaLogicaNegocio.Entidades
{
    public class NUsuario
    {

        DUsuario dUsuario = new DUsuario();

        public bool Login(int userId, string pass) => dUsuario.Login(userId, pass);

        public DataTable MostrarUsuarios()
        {
            return new DUsuario().MostrarUsuarios();
        }

        public static string InsertarUsuario(string nombre, string apellido, string contraseña, int telefeno, string correo, int idRoles)
        {
            DUsuario objUsuario = new DUsuario();
            objUsuario.Nombre = nombre;
            objUsuario.Apellido = apellido;
            objUsuario.Contraseña = contraseña;
            objUsuario.Telefeno = telefeno;
            objUsuario.Correo = correo;
            objUsuario.IdRoles = idRoles;

            return objUsuario.InsertarUsuario(objUsuario);
        }
    }

}
