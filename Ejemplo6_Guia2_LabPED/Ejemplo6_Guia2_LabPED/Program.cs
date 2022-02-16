using System;

namespace Ejemplo6_Guia2_LabPED
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            char caracter;
            pila mipila = new pila();
            pila pilafrase = new pila();

            //PARTE 1
            //SE INGRESAN CARACTERES DE MANERA INDIVIDUAL
            Console.WriteLine("\t\t---PARTE I---");
            //ingresamos elementos a la pila
            mipila.Push('p');
            mipila.Push('b');
            mipila.Push('z');
            mipila.Push('s');
            //mostramos el contenido de la pila
            mipila.mostrar();
            Console.ReadLine();
            //sacamos un elemento de la pila
            mipila.Pop();
            mipila.mostrar();
            mipila.Pop();
            mipila.mostrar();
            Console.ReadLine();

            //PARTE 2
            //SE INGRESA UNA CADENA Y SE INGRESAN TODOS LOS
            //CARACTERES DE DICHA CADENA
            Console.WriteLine("\t\t---PARTE II---");
            Console.Write("Ingrese la palabra: "); cadena = Console.ReadLine();

            for (int i = 0; i < cadena.Length; i++)
            {
            // extrae una caracter de la cadena y lo convierte en char
            caracter = char.Parse(cadena.Substring(i, 1));
            pilafrase.Push(caracter);
            }  //imprimir el contenido de la pila
            pilafrase.mostrar();
            Console.ReadLine();
        }
    }
}
