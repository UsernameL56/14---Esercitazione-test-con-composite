using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Domanda : Componente
    {
        // attributi
        List<Risposta> _risposta = new List<Risposta>();
        // attributi
        protected string _testo;

        // metodi accessor
        public List<Risposta> Risposta
        {
            get { return _risposta; }
            set { _risposta = value; }
        }
        public string Testo
        {
            get { return _testo; }
            set { _testo = value; }
        }

        // costruttore
        public Domanda(List<Componente> _risposta, string _testo)
        {
            Risposta = _risposta.OfType<Risposta>().ToList();
            Testo = _testo;
        }

        // metodi
        public override void Add(Componente _risposta)
        {
            Risposta risposta = (Risposta) _risposta;
            Risposta.Add(risposta);
        }
        public void AggiungiRisposta(string testo, int punteggio, bool correttezza)
        {
            Risposta.Add(new Classi.Risposta(testo, punteggio, correttezza));
        }
        public override void Remove(int indice)
        {
            if (indice >= 0 && indice < Risposta.Count)
                Risposta.RemoveAt(indice);
        }
        public override Componente GetChild(int indice)
        {
            if (indice < Risposta.Count)
                return Risposta[indice];
            else
                return null;
        }
        public override string ToString()
        {
            string result = $"Tipo: {this.GetType().Name}\n";
            result += $"Domanda: {Testo}\n";

            foreach (var risposta in Risposta)
            {
                result += $" - {risposta.Testo} (Correttezza: {risposta.Correttezza}, Punteggio: {risposta.Punteggio})\n";
            }

            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Domanda domanda2 = (Domanda)obj;

            foreach (var domanda in Risposta)
            {
                if (!domanda.Equals(domanda2))
                {
                    return false;
                }
            }

            return true;

        }
        public override int CalcoloPunteggio()
        {
            int punteggio = 0;
            foreach(Risposta risposta in Risposta)
            {
                if(risposta.Correttezza)
                punteggio += risposta.Punteggio;
            }

            return punteggio;
        }
    }
}
