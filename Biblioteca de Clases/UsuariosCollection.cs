using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class UsuariosCollection
    {
        //Conexion a BD
        private DataBaseLocalEntities _db = new DataBaseLocalEntities();
        public DataBaseLocalEntities DB { get => _db; set => _db = value; }

        //Método para leer todo
        public IEnumerable<Object> LeerUsuarios()
        {
            return(from u in DB.Usuario select u).ToList();
        }    
        //Retornar todo en Lista trabajables
        public List<Usuarios> ListaUsuario()
        {
            return (from u in DB.Usuario 
                    select new Usuarios()
                    {
                        Id = u.id,
                        User = u.usuario1,
                        Pass = u.contrasena
                    }).ToList();
        }

        //Metodo para Agregar Usuarios
        public bool AgregarUsuario(Usuarios user)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.usuario1 = user.User;
                usuario.contrasena = user.Pass;
                DB.Usuario.Add(usuario);
                DB.SaveChanges();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        //Metodo para Eliminar Usuarios
        public bool EliminarUsuario(string id)
        {
            try
            {
                Usuario user = DB.Usuario.Find(id);
                DB.Usuario.Remove(user);
                DB.SaveChanges();
                return true;
            } 
            catch (Exception)
            {
                return false;
            }
        }

        //Metodo para Modificar Usuarios
        public bool ModificarUsuario(Usuarios user)
        {
            try
            {
                Usuario usuarios = DB.Usuario.Find(user.Id);
                usuarios.usuario1 = user.User;
                usuarios.contrasena = user.Pass;
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Metodo para leer tipos de Usuario
        //public IEnumerable<Object> LeerTipoUsuario()
        //{
        //    return (from t in DB.TIPOUSUARIOS select t).ToList();
        //}


    }
}
