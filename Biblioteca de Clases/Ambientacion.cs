using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class Ambientacion
    {
        //Declaración de Atributos
        private int _idTipoAmbientacion;
        private String _descripcion;

        //Metodos Atributos
        public int IdAmbientacion { get => _idTipoAmbientacion; set => _idTipoAmbientacion = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        //Constructores
        public Ambientacion()
        {
            this.Init();
        }

        public Ambientacion(int id)
        {
            IdAmbientacion = id;
        }

        public Ambientacion(int id, string desc)
        {
            IdAmbientacion = id;
            Descripcion = desc;
        }

        private void Init()
        {
            Descripcion = string.Empty;
        }




    }
}
