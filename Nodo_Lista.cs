using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201114567
{
    class Nodo_Lista
    {
        public string nombre;
        public string password;
        private Nodo_Lista siguiente;
        private Nodo_Lista anterior;

        public Cola cola;
        public Pila pila;

        public Nodo_Lista Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo_Lista Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
}
