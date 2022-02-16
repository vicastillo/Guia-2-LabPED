using System;

namespace Ejemplo3_Guia2_LabPED
{
    class Program
    {
        static void Main(string[] args)
        {
            cola objcola = new cola();
            Console.WriteLine("Colocando 5 elementos en la cola");

            objcola.Encolar(3);
            objcola.Encolar(27);
            objcola.Encolar(5);
            objcola.Encolar(22);
            objcola.Encolar(23);
            objcola.Mostrar();

            Console.WriteLine("Retirando dos elementos de la cola");
            objcola.Desencolar();
            objcola.Mostrar();
            objcola.Desencolar();
            objcola.Mostrar();

            Console.WriteLine("Se va a retirar un nodo más, con el valor de {0}", objcola.DesencolarValor());

            objcola.Mostrar();
            Console.ReadLine();
        }
    }
}
