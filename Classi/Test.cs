using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Test : Componente
    {
        // attributi
        private List<Componente> _domanda = new List<Componente>();

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
        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType())
                return false;

            Test test2 = (Test)obj;
            
            foreach (var domanda in Domanda)
            {
                if (!domanda.Equals(test2))
                {
                    return false;
                }
            }

            return true;

        }
        public override int CalcoloPunteggio()
        {
            int punteggio = 0;
            foreach (var domanda in Domanda)
            {
                punteggio += domanda.CalcoloPunteggio();
            }

            return punteggio;
        }
    }
}
