using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo6_Guia2_LabPED
{
    class pila
    {
        public nodo tope;
        public pila()
        {
            tope = null;
        }
        public void Push(char valor)
        {
            nodo aux = new nodo();
            aux.info = valor;
            // si no hay nada en la pila
            if (tope == null)
            {
                //se asigna el aux como el único nodo
                tope = aux;
                //como solo hay un dato en la pila el
                aux.sgte = null;
            }
            else
            {
                //si la pila no está vacía el dato se inserta arriba de la pila
                //es decir en el tope
                aux.sgte = tope;
                tope = aux;
            }
        }
        public void mostrar()
        {
            nodo puntero; puntero = tope;
            Console.WriteLine("{0}", puntero.info);
            //se recorre el puntero del tope a el fondo
            while (puntero.sgte != null)
            {
                puntero = puntero.sgte;
                Console.WriteLine("{0}", puntero.info);
            }
        }
        public char Pop()
        {
            char valor = ' ';
            if (tope == null)
                Console.WriteLine("Pila vacia");
            else
            {
                //se elimina el último en entrar y se retorna el valor que se elimina
                valor = tope.info;
                tope = tope.sgte;
            }
            return valor;
        }
    }
}
