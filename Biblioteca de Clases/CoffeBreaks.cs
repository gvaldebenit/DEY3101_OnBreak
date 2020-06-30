using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class CoffeBreaks
    {
        //Atributos
        private string _numero;
        private bool _vegetariano;

        //Metodos Atributos
        public string Numero { get => _numero; set => _numero = value; }
        public bool Vegetariano { get => _vegetariano; set => _vegetariano = value; }

        //Constructores
        public CoffeBreaks()
        {
            this.Init();
        }


        public CoffeBreaks(string numero, bool vegetariano)
        {
            Numero = numero;
            Vegetariano = vegetariano;
        }

        private void Init()
        {
            Vegetariano = false;
        }
    }
}
