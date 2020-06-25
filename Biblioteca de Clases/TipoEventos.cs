using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class TipoEventos
    {
        //Atributos
        private int _id;
        private string _descripcion;

        //Metodos de Atributos
        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
       
        //Constructores
        public TipoEventos()
        {
            this.Init();
        }

        public TipoEventos(int id)
        {
            Id = id;
        }

        public TipoEventos(int id, string desc)
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

