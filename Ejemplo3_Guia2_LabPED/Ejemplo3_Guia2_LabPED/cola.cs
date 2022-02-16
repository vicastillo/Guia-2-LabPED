using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo3_Guia2_LabPED
{
    class cola
    {
        public nodo primero; //inicio de la cola
        public nodo ultimo; //final de la cola

        public cola()
        {
        primero = ultimo = null;
        }

        public void Encolar (int valor)
        {
            nodo aux = new nodo();
            aux.info = valor;
            if(primero == null) //en caso la cola esté vacia
            {
                primero = ultimo = aux; // ingresamos dato a la cola
                aux.sgte = null; //hacemos que señale a null el nodo
            }
            else //si la cola no está vacia
            {
                ultimo.sgte = aux; //el último elemento va a señalar a aux
                aux.sgte = null;
                ultimo = aux; //metemos el nodo a la cola
            }
        }

        public void Desencolar() //desencola sin decirme el valor
        {
            if (primero == null) Console.WriteLine("Cola vacia"); //si la cola está vacia enviamos el mensaje
            else primero = primero.sgte; //cambiamos de posición el apuntador primero
        }

        public int DesencolarValor() //desencola y me muestra valor desencolado
        {
            int valor = 0;
            if (primero == null) Console.WriteLine("Cola vacia");
            else
            {
                valor = primero.info;
                primero = primero.sgte;
            }
            return valor;
        }

        public void Mostrar()
        {
            if (primero == null) Console.WriteLine("Cola vacia");
            else
            {
                nodo puntero;
                puntero = primero;

                do
                {
                    Console.Write("{0}\t", puntero.info);
                    puntero = puntero.sgte;
                }
                while (puntero != null);
            }
            Console.WriteLine("\n");
        }
    }//fin de la clase cola
}
