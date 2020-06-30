using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class Cocktails
    {
        //Atributos
        private string _numero;
        private Ambientacion _ambientacion;
        private bool _poseeAmbientacion;
        private bool _musicaAmbiental;
        private bool _musicaCliente;

        //Metodos Atributos
        public string Numero { get => _numero; set => _numero = value; }
        public Ambientacion Ambientacion { get => _ambientacion; set => _ambientacion = value; }
        public bool PoseeAmbientacion { get => _poseeAmbientacion; set => _poseeAmbientacion = value; }
        public bool MusicaAmbiental { get => _musicaAmbiental; set => _musicaAmbiental = value; }
        public bool MusicaCliente { get => _musicaCliente; set => _musicaCliente = value; }

        //Constructores
        public Cocktails()
        {
            this.Init();
        }

        public Cocktails(string numero, Ambientacion ambientacion, bool poseeAmbientacion, bool musicaAmbiental, bool musicaCliente)
        {
            Numero = numero;
            Ambientacion = ambientacion;
            PoseeAmbientacion = poseeAmbientacion;
            MusicaAmbiental = musicaAmbiental;
            MusicaCliente = musicaCliente;
        }

        private void Init()
        {
            Numero = String.Empty;
            Ambientacion = new Ambientacion();
            PoseeAmbientacion = false;
            MusicaAmbiental = false;
            MusicaCliente = false;
        }
    }
}
