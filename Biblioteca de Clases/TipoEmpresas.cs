using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    
    public class TipoEmpresas 
    {
        //Atributos
        private int _id;
        private string _descripcion;

        //Metodos de Atributo
        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        //Constructores
        public TipoEmpresas()
        {
            this.Init();
        }

        public TipoEmpresas(int id)
        {
            Id = id;
        }

        public TipoEmpresas(int id, string desc)
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
