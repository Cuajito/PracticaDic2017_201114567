using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201114567
{
    class Nodo_Pila
    {
        private int dato;
        private Nodo_Pila siguiente;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo_Pila Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}