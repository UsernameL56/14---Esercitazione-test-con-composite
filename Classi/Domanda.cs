using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Domanda : Componente
    {
        // attributi
        List<Componente> _tipoDomanda = new List<Componente>();

        // metodi accessor
        public List<Componente> TipoDomanda
        {
            get { return _tipoDomanda; }
            set { _tipoDomanda = value; }
        }

        // costruttore
        public Domanda(List<Componente> _tipoDomanda)
        {
            TipoDomanda = _tipoDomanda;
        }

        // metodi
        public override void Add(Componente _tipoDomanda)
        {
            TipoDomanda.Add(_tipoDomanda);
        }
        public override void Remove(int indice)
        {
            if (indice >= 0 && indice < TipoDomanda.Count)
                TipoDomanda.RemoveAt(indice);
        }
        public override Componente GetChild(int indice)
        {
            if (indice < TipoDomanda.Count)
                return TipoDomanda[indice];
            else
                return null;
        }
        public override string ToString()
        {
            string stringa = "";
            foreach (Componente tipoDomanda in TipoDomanda)
            {
                stringa += tipoDomanda.ToString();
            }

            return stringa;
        }
    }
}
