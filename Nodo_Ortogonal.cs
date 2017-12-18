using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201114567
{
    class Nodo_Ortogonal
    {
        private Nodo_Ortogonal right;
        private Nodo_Ortogonal left;
        private Nodo_Ortogonal up;
        private Nodo_Ortogonal down;
        public int fila;
        public int columna;
        public int dato;



        public Nodo_Ortogonal Right
        {
            get { return right; }
            set { right = value; }
        }

        public Nodo_Ortogonal Left
        {
            get { return left; }
            set { left = value; }
        }

        public Nodo_Ortogonal Up
        {
            get { return up; }
            set { up = value; }
        }

        public Nodo_Ortogonal Down
        {
            get { return down; }
            set { down = value; }
        }
    }
}
