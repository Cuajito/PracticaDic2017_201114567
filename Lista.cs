using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201114567
{
    class Lista
    {
        Nodo_Lista primero = new Nodo_Lista();
        Nodo_Lista ultimo = new Nodo_Lista();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void insertarNodo(string name, string pass) 
        {
            Nodo_Lista nuevo = new Nodo_Lista();
            Cola queve = new Cola();
            Pila stack = new Pila();
            
            nuevo.nombre = name;
            nuevo.password = pass;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.Siguiente = primero;
                primero.Anterior = ultimo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
                primero.Anterior = ultimo;
            }

            Console.WriteLine("\n nuevo nodo ingresado con exito \n");  
        }

        public void buscarNodo()
        {
            Nodo_Lista actual = new Nodo_Lista();
            actual = primero;
            bool encontrado = false;
            Console.Write("Ingrese el dato a buscar: ");
            string nodobuscado = Console.ReadLine();
            if (actual != null)
            {
                do
                {
                    if (actual.nombre == nodobuscado)
                    {
                        Console.Write("nodo con el dato ({}) Encontrado", actual.nombre);
                        encontrado = true; 
                    }

                    actual = actual.Siguiente;

                } while (actual != primero && encontrado!= true);

                if (!encontrado) 
                {
                    Console.Write("Nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia \n");

            }
        }

        public Boolean eliminarNodo(string name, string pass)
        {
            Nodo_Lista actual = new Nodo_Lista();
            actual = primero;
            Nodo_Lista ant = new Nodo_Lista();
            ant = null;
            bool encontrado = false;
            string nodobuscado = name;
            string contrasena = pass;

            if (actual != null)
            {
                do
                {
                    if (actual.nombre == nodobuscado && actual.password == contrasena)
                    {
                        if (actual == primero)
                        {
                            primero = primero.Siguiente;
                            primero.Anterior = ultimo;
                            ultimo.Siguiente = primero;
                        }
                        else if (actual == ultimo)
                        {
                            ultimo = ant;
                            ultimo.Siguiente = primero;
                            primero.Anterior = ultimo;
                        }
                        else 
                        {
                            ant.Siguiente = actual.Siguiente;
                            actual.Siguiente.Anterior = ant;
                        }

                        Console.WriteLine("Nodo eliminado con exito");
                        encontrado = true;
                        return true;
                    }
                    ant = actual;
                    actual = actual.Siguiente;

                } while (actual != primero && encontrado != true);

                if (!encontrado)
                {
                    Console.Write("Nodo no encontrado");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia \n");
                return false;

            }

            return false;
 

        }

        public string imprimirPrimeroUltimo()
        {
            string usuarios = "digraph usuarios{";
            Nodo_Lista actual = new Nodo_Lista();
            actual = primero;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine("" + actual.nombre);
                    usuarios += ""+actual.nombre+"->";
                    actual = actual.Siguiente;

                } while (actual != primero);

                usuarios += "Fin;";
                return usuarios;
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia \n");
                usuarios += "}";
                return usuarios;
 
            }

 
        }

        public void imprimirUltimoPrimero()
        {
            Nodo_Lista actual = new Nodo_Lista();
            actual = ultimo;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine("" + actual.nombre);
                    actual = actual.Anterior;

                } while (actual != ultimo );
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia \n");

            }
        }
    }
}
