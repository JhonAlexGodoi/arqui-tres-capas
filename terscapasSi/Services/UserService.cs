using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terscapasSi.Model.Entities;


namespace terscapasSi.Services
{
    internal class UserService
    {

        // simulacuion de tabla de bbdd usuarios
        private List<User> tablaUsuarios = new List<User>();


        //**************************************
        //crear usuario nuevo
        public bool CrearUsuario(User nuevoUsuario)
        {
            try
            {
                tablaUsuarios.Add(nuevoUsuario); //agregar nuevo usuaroio a la list
                return true; 


            } catch
            {
                return false;
            }
        }

        //**************************************
        //obtener todos los usuarios
        public List<User> ObtenerTodos()
        {
            return tablaUsuarios;
        }

        //**************************************
        //obtener usuarios por id
        public User ObtenerPorID(int id)
        {
            return tablaUsuarios.Find(u => u.Id == id);
        }


        //**************************************
        //actualizar usuario existente
        public bool ActualizarUsuario(int id, User usuarioActualizado)
        {
            try
            {
                var usuario = ObtenerPorID(id);

                if (usuario != null)
                {
                    usuario.Name = usuarioActualizado.Name;
                    usuario.Email = usuarioActualizado.Email;
                    usuario.Password = usuarioActualizado.Password;
                    usuario.Activo = usuarioActualizado.Activo;
                }
                return true;
            } 
            catch
            {
                return false;
            }
        }

        //**************************************
        //eliminar usuario por Id
        public bool EliminarUsuario(int id)
        {
            try
            {
                var usuario = ObtenerPorID(id);
                if (usuario != null)
                {
                    tablaUsuarios.Remove(usuario);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }



    }
}
