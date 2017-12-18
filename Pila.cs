using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201114567
{
    class Pila
    {
        private Nodo_Pila Primero = new Nodo_Pila();
        public Pila()
        {
            Primero = null;
        }

        public void insertarNodo()
        {
            Nodo_Pila Nuevo = new Nodo_Pila();
            Console.Write("ingrese el dato que contendra el nuevo nodo: ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            Nuevo.Siguiente = Primero;
            Primero = Nuevo;

            Console.WriteLine("\n Nodo ingresado \n");
            
        }

        public void imprimirPila()
        {
            Nodo_Pila Actual = new Nodo_Pila();
            Actual=Primero;

            if (Primero!= null)
            {
                while(Actual!=null)
                {
                    Console.WriteLine("" + Actual.Dato);
                    Actual=Actual.Siguiente;
                }
                
            }
            else
            {
                Console .WriteLine("\n la pila se encuentra vacia \n");
            }
        }

        public void pop()
        {
            Nodo_Pila actual = new Nodo_Pila();
            actual = Primero;

            if (Primero != null)
            {
                if (actual == Primero)
                {
                    //acciones con el dequeue
                    Primero = Primero.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("la cola esta vacia");
            } 
 
        }

        public void peek_pila()
        {
            Nodo_Pila actual = new Nodo_Pila();
            actual = Primero;

            if (Primero != null)
            {
                if (actual == Primero)
                {
                    //acciones con el peek
                }
            }
            else
            {
                Console.WriteLine("la cola esta vacia");
            }
 
        }
    }
}