using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Singola : Domanda
    {
        // costruttore
        public Singola(List<Componente> risposta, string _testo) : base(risposta, _testo)
        {

        }
        // metodi
        public override int CalcoloPunteggio()
        {
            int punteggio = 0;

            foreach (Risposta risposta in Risposta)
            {
                if (risposta.Correttezza)
                {
                    punteggio += risposta.Punteggio;
                }
            }
            return punteggio;
        }
    }
}
