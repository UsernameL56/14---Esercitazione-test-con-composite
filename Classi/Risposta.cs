using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Risposta : Componente
    {
        // attributi
        public string _testo;
        public int _punteggio;
        public bool _correttezza;

        // metodi accessor
        public string Testo
        {
            get { return _testo; }
            set { _testo = value; }
        }
        public int Punteggio { 
            get { return _punteggio;}
            set { _punteggio = value; }
        }
        public bool Correttezza
        {
            get { return _correttezza; }
            set { _correttezza = value; }
        }

        // costruttore
        public Risposta(string _testo, int _punteggio, bool _correttezza)
        {
            Testo = _testo;
            Punteggio = _punteggio;
            Correttezza = _correttezza;
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
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Risposta risposta2 = (Risposta)obj;

            return Testo == risposta2.Testo;
        }
        public override int CalcoloPunteggio()
        {
            throw new NotImplementedException();
        }
    }
}
