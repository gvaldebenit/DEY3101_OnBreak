using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class Clientes
    {
        //Atributos de Cliente
        private string _rut;
        private string _nombreContacto;
        private string _direccion;
        private string _telefono;
        private string _emailContacto;
        private string _razonSocial;
        private ActividadEmpresas _actividadEmpresa;
        private TipoEmpresas _tipoEmpresa;

        //Metodos de Atributo
        public String Rut { get => _rut; set => _rut = value; }
        public String NombreContacto { get => _nombreContacto; set => _nombreContacto = value; }
        public String Direccion { get => _direccion; set => _direccion = value; }
        public String Telefono { get => _telefono; set => _telefono = value; }
        public String EmailContacto { get => _emailContacto; set => _emailContacto = value; }
        public String RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public ActividadEmpresas ActividadEmpresa { get => _actividadEmpresa; set => _actividadEmpresa = value; }
        public TipoEmpresas TipoEmpresa { get => _tipoEmpresa; set => _tipoEmpresa = value; }

   
        //Constructor
        public Clientes()
        {
            this.Init();
        }

        private void Init()
        {
            this.Rut = String.Empty;
            this.NombreContacto = String.Empty;
            this.Direccion = String.Empty;
            this.Telefono = String.Empty;
            this.EmailContacto = String.Empty;
            this.RazonSocial = String.Empty;
            this.ActividadEmpresa= new ActividadEmpresas();
            this.TipoEmpresa = new TipoEmpresas();
        }


    }
}
