using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class ModalidadServicios
    {
        //Atributos
        private string _id;
        private TipoEventos _tipoEvento;
        private string _nombre;
        private double _valorbase;
        private int _personalBase;

        //Metodos de Atributos
        public string Id { get => _id; set => _id = value; }
        public TipoEventos TipoEvento { get => _tipoEvento; set => _tipoEvento = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Valorbase { get => _valorbase; set => _valorbase = value; }
        public int PersonalBase { get => _personalBase; set => _personalBase = value; }

        //Constructores
        public ModalidadServicios()
        {
            this.Init();
        }

        public ModalidadServicios(string id)
        {
            Id = id;
            TipoEvento = new TipoEventos();
        }

        public ModalidadServicios(string id, TipoEventos tipoEvento, string nombre, 
            double valorbase, int personalBase)
        {
            Id = id;
            TipoEvento = tipoEvento;
            Nombre = nombre;
            Valorbase = valorbase;
            PersonalBase = personalBase;
        }

        private void Init()
        {
            Nombre = String.Empty;
            Valorbase = 0;
            PersonalBase = 0;
            TipoEvento = new TipoEventos();
        }
    }
}
