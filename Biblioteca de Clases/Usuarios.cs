using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class Usuarios
    {
        //Atributos
        private int _id;
        private string _user;
        private string pass; 

        //Metodos de atributos
        public int Id { get => _id; set => _id = value; }
        public string User { get => _user; set => _user = value; }
        public string Pass { get => pass; set => pass = value; }
        
        //Constructores
        public Usuarios()
        {
            User = string.Empty;
            Pass = string.Empty;
        }

        public Usuarios(int id)
        {
            Id = id;
        }

        public Usuarios(int id, string usuario, string pass)
        {
            Id = id;
            User = usuario;
            Pass = pass;
        }
    }
}
