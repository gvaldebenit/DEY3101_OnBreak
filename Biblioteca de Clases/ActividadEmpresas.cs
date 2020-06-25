using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class ActividadEmpresas
    {
        //Atributos
        private int _id;
        private string _descripcion;

        //Metodos de Atributo
        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        
        //Constructores
        public ActividadEmpresas()
        {
            this.Init();
        }

        public ActividadEmpresas(int id)
        {
            Id = id;
        }

        public ActividadEmpresas(int id, string desc)
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
