using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class TipoUsuarios
    {
        //Atributos
        private int _id;
        private string _descripcion;

        //Metodos de Atributo
        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        //Constructores
        public TipoUsuarios()
        {
            this.Init();
        }

        public TipoUsuarios(int id)
        {
            Id = id;
        }

        public TipoUsuarios(int id, string desc)
        {
            Id = id;
            Descripcion = desc;
        }

        private void Init()
        {
            Descripcion = string.Empty;
        }
    }
}
