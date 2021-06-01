using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instagramforce.Clases.Lista_doblemente_enlazada
{
    class NodoDoble
    {
        Object dato;
        public NodoDoble siguiente, atras;

        public NodoDoble()
        {
        }
        public NodoDoble(Object entrada)
        {
            dato = entrada;
            siguiente = atras = null;
        }
    }
}
