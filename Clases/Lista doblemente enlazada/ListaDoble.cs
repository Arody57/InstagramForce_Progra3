using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instagramforce.Clases.Lista_doblemente_enlazada
{
    class ListaDoble
    {
        private NodoDoble inicio, fin;
        public ListaDoble()
        {
            inicio = fin = null;
        }

        public bool estVacia()
        {
            return inicio == null;
        }

        public void insertarAlFinal(NodoDoble anterior, Object entrada)
        {
            NodoDoble nuevo = new NodoDoble();

            nuevo.siguiente = anterior.siguiente;
            if (anterior.siguiente != null)
            {
                anterior.siguiente.atras = nuevo;
                anterior.siguiente = nuevo;
                nuevo.atras = anterior;
            }
        }

        public NodoDoble getInicio()
        {
            return inicio;
        }
    }
}
