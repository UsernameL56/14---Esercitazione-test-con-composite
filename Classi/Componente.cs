using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public abstract class Componente
    {
        public abstract void Add(Componente componente);
        public abstract void Remove(int indice);
        public abstract Componente GetChild(int indice);
        public abstract string ToString();
        public abstract bool Equals(object obj);
        public abstract int CalcoloPunteggio();
    }
}
