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
        //esto es para poder hacer uso de un objeto y a traves de él acceder a los métodos de la capa Datos
        DUsuario dUsuario = new DUsuario(); //Parece que nunca lo utilizas

        public bool Login(int userId, string pass) => dUsuario.Login(userId, pass);

        public DataTable MostrarUsuarios()
        {
            return new DUsuario().MostrarUsuarios();
        }

  
        public static string InsertarUsuario(string nombre, string apellido, string contraseña, int telefeno, string correo, int idRoles)
        {
            //Aqui se crear un nuevo objeto que hace referencia a la capa datos DUsuario
            // y se le envían los valores que traen los parametros y se le asignan a cada propiedad de la Capa Datos DUsuario
            DUsuario objUsuario = new DUsuario();
            objUsuario.Nombre = nombre;
            objUsuario.Apellido = apellido;
            objUsuario.Contraseña = contraseña;
            objUsuario.Telefeno = telefeno;
            objUsuario.Correo = correo;
            objUsuario.IdRoles = idRoles;

            //se le envian todos al metos que esta en la capa Datos mediante el objeto objUsuario.
            //por aquí todo ok.
            return objUsuario.InsertarUsuario(objUsuario);
        }

        public static DataTable BuscarUsuario(string TBuscar)
        {
            DUsuario objUsuario = new DUsuario();
            objUsuario.TBuscar = TBuscar;
            return objUsuario.BuscarUsuario(objUsuario);
        }

        public static string EliminarUsuario(int idUsuarios)
        {
            DUsuario dUsuario = new DUsuario();
            dUsuario.IdUsuarios = idUsuarios;

            return dUsuario.EliminarUsuario(dUsuario);
            
        }

        public static string EditarUsuario(string nombre, string apellido, string contraseña, int telefeno, string correo, int idRoles)
        {
            DUsuario objUsuario = new DUsuario();
            objUsuario.Nombre = nombre;
            objUsuario.Apellido = apellido;
            objUsuario.Contraseña = contraseña;
            objUsuario.Telefeno = telefeno;
            objUsuario.Correo = correo;
            objUsuario.IdRoles = idRoles;

            return objUsuario.EditarUsuario(objUsuario);
        }
    } 

}
