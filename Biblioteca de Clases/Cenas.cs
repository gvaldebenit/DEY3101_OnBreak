using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class Cena
    {
        //Declaración de Variables 
        private string _numero;
        private Ambientacion _ambientacion;
        private bool _musicaAmbiental;
        private bool _localOnBreak;
        private bool _otroLocal;
        private float _valorArriendo;

        //Metodos Atributos
        public string Numero { get => _numero; set => _numero = value; }
        public Ambientacion Ambientacion { get => _ambientacion; set => _ambientacion = value; }
        public bool MusicaAmbiental { get => _musicaAmbiental; set => _musicaAmbiental = value; }
        public bool LocalOnBreak { get => _localOnBreak; set => _localOnBreak = value; }
        public bool OtroLocal { get => _otroLocal; set => _otroLocal = value; }
        public float ValorArriendo { get => _valorArriendo; set => _valorArriendo = value; }

        //Constructores
        public Cena()
        {
            this.Init();
        }

        public Cena(string numero, Ambientacion ambientacion, bool musica, bool localOB, bool otrolocal, float valor)
        {
            Numero = numero;
            Ambientacion = ambientacion;
            MusicaAmbiental = musica;
            LocalOnBreak = localOB;
            OtroLocal = otrolocal;
            ValorArriendo = valor;
        }

        private void Init()
        {
            Numero = String.Empty;
            Ambientacion = new Ambientacion();
            MusicaAmbiental = false;
            LocalOnBreak = false;
            OtroLocal = false;
            ValorArriendo = 0;
        }
    }
}
