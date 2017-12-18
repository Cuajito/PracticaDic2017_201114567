using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201114567
{
    class Matriz_Ortogonal
    {
        Nodo_Ortogonal first = new Nodo_Ortogonal();
        Nodo_Ortogonal last = new Nodo_Ortogonal();
        Nodo_Ortogonal first_ant = new Nodo_Ortogonal();
        

        public Matriz_Ortogonal()
        {
            first = null;
            last = null;
            first_ant = null;
        }

        public void crear_matriz(int row, int column)
        {
            int filas = row;
            int columnas = column;
            Nodo_Ortogonal actual = new Nodo_Ortogonal();

            for (int i = 0; i < filas; i++) 
            {
                first_ant = first;
                first = null;

                for (int j = 0; j < columnas; j++)
                {
                    Nodo_Ortogonal Nuevo = new Nodo_Ortogonal();
                    Nuevo.dato=0;
                    Nuevo.columna = j;
                    Nuevo.fila = i;

                    if (first == null)
                    {
                        first = Nuevo;
                        first.Right = null;
                        first.Left = null;
                        last = first;
                    }
                    else
                    {
                        last.Right = Nuevo;
                        Nuevo.Right = null;
                        Nuevo.Left = last;
                        last = Nuevo;
                    }
                    Console.WriteLine("nodo ingresado en: [" + Nuevo.fila.ToString() + "," + Nuevo.columna.ToString() + "]");
                    
                }

                if (first != null && first_ant != null)
                {
                    unir_nodos();
                }
            }

        
        }

        public void unir_nodos()
        {
            Nodo_Ortogonal actual = new Nodo_Ortogonal();
            Nodo_Ortogonal actual_ant = new Nodo_Ortogonal();
            
            actual = first;
            actual_ant = first_ant;

            while (actual != null && actual_ant != null)
            {
                actual.Up = actual_ant;
                actual_ant.Down = actual;
                actual = actual.Right;
                actual_ant = actual_ant.Right;
            }

        }
    }
}
