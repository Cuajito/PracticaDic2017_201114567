using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201114567
{
    class Cola
    {
        private Nodo_Cola Primero = new Nodo_Cola();
        private Nodo_Cola Ultimo = new Nodo_Cola();

        public Cola()
        {
            Primero = null;
            Ultimo = null;
        }

        public void insertarNodo()
        {
            Nodo_Cola Nuevo = new Nodo_Cola();
            Console.Write("ingrese el valor que contendra el nodo");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;

            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;

            }
            Console.WriteLine("\n nodo ingresado \n");
        }

        public void desplegarCola()
        {
            Nodo_Cola Actual = new Nodo_Cola();
            Actual = Primero;
            if (Primero != null)
            {
                while(Actual!=null)
                {
                    Console.WriteLine("" + Actual.Dato);
                    Actual=Actual.Siguiente;
                
                }

            }
            else 
            {
                Console.WriteLine("\n La cola esta vacia \n");
            }

        
        }

        public void dequeue() 
        {
            Nodo_Cola actual = new Nodo_Cola();
            actual = Primero;

            if (Primero != null)
            {
                if (actual == Primero)
                {
                        //acciones con el dequeue
                        Primero=Primero.Siguiente;
                }            
            }
            else
            {
                Console.WriteLine("la cola esta vacia");
            } 
        }

        public void peek_cola()
        {
            Nodo_Cola actual = new Nodo_Cola();
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