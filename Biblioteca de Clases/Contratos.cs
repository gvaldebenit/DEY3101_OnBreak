using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class Contratos
    {
        //Atributos
        private Clientes _cliente;
        private string _numeroContrato;
        private string _nombreEvento;
        private string _direccion;
        private ModalidadServicios _modalidadServicio;
        private int _cantidadAsistentes;
        private int _personalAdicional;
        private double _total;
        private DateTime _creacionContrato;
        private DateTime _inicioEvento;
        private DateTime _terminoEvento;
        private DateTime? _terminoContrato;
        private string _observaciones;
        private bool _realizado;

        //Metodos de Atributos
        public Clientes Cliente { get => _cliente; set => _cliente = value; }
        public string NumeroContrato { get => _numeroContrato; set => _numeroContrato = value; }
        public string NombreEvento { get => _nombreEvento; set => _nombreEvento = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public ModalidadServicios ModalidadServicio { get => _modalidadServicio; set => _modalidadServicio = value; }
        public int CantidadAsistentes { get => _cantidadAsistentes; set => _cantidadAsistentes = value; }
        public int PersonalAdicional { get => _personalAdicional; set => _personalAdicional = value; }
        public double Total { get => _total; set => _total = value; }
        public DateTime CreacionContrato { get => _creacionContrato; set => _creacionContrato = value; }
        public DateTime InicioEvento { get => _inicioEvento; set => _inicioEvento = value; }
        public DateTime TerminoEvento { get => _terminoEvento; set => _terminoEvento = value; }
        public DateTime? TerminoContrato { get => _terminoContrato; set => _terminoContrato = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public bool Realizado { get => _realizado; set => _realizado = value; }


        //Constructores
        public Contratos()
        {
            this.Init();
        }

        private void Init()
        {
            this.Cliente = new Clientes();
            this.NumeroContrato = String.Empty;
            this.NombreEvento = String.Empty;
            this.Direccion = String.Empty;
            this.ModalidadServicio = new ModalidadServicios();
            this.CantidadAsistentes = 0;
            this.PersonalAdicional = 0;
            this.Total = 0;
            this.CreacionContrato = DateTime.Now;
            this.TerminoContrato = null;
            this.InicioEvento = DateTime.MinValue;
            this.TerminoEvento = DateTime.MinValue;
            this.Observaciones = String.Empty;
            this.Realizado = true;
        }

    }
}
