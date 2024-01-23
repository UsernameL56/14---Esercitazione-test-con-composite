using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Test : Componente
    {
        // attributi
        List<Componente> _domanda = new List<Componente>();

        // metodi accessor
        public List<Componente> Domanda
        {
            get { return _domanda; }
            set { _domanda = value; }
        }

        // costruttore
        public Test(List<Componente> _domanda)
        {
            Domanda = _domanda;
        }

        // metodi
        public override void Add(Componente domanda)
        {
            Domanda.Add(domanda);
        }
        public override void Remove(int indice)
        {
            if (indice >= 0 && indice < Domanda.Count)
                Domanda.RemoveAt(indice);
        }
        public override Componente GetChild(int indice)
        {
            if(indice < Domanda .Count)
                return Domanda[indice];
            else
                return null;
        }
        public override string ToString()
        {
            string stringa = "";
            foreach(Componente domanda in Domanda)
            {
                stringa += domanda.ToString();
            }

            return stringa;
        }
    }
}
