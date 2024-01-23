using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Multipla : Componente
    {
        // attributi
        private string _testo;

        // metodi accessor
        public string Testo
        {
            get { return _testo; }
            set { _testo = value; }
        }

        // costruttore
        public Multipla(string _testo)
        {
            Testo = _testo;
        }

        // metodi
        public override void Add(Componente componente)
        {
            throw new NotImplementedException();
        }
        public override void Remove(int indice)
        {
            throw new NotImplementedException();
        }
        public override Componente GetChild(int indice)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{Testo}";
        }
    }
}
