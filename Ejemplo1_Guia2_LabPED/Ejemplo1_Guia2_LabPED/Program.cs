using System;

namespace Ejemplo1_Guia2_LabPED
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos una instancia de la clase lista para que podamos utilizar los métodos
            lista listanueva = new lista();

            //le agregamos cuatro nodos a la lista
            listanueva.InsertarI(40);
            listanueva.InsertarI(30);
            listanueva.InsertarI(20);
            listanueva.InsertarI(10);

            //mostramos qué hay contenido dentro de la lista
            listanueva.mostrar();

            //insertando en posición
            listanueva.InsertarP(220, 3);
            listanueva.mostrar();

            Console.ReadKey();
        }
    }

    class nodo
    {
        public int dato; //dato que almacena el valor del nodo, en este caso entero
        public nodo siguiente; //atributo que señala al siguiente nodo, clase auto referenciada
    }

    class lista
    {
        public nodo inicio; // cabeza de la lista

        //constructor por defecto
        public lista()
        { inicio = null; }

        public void insertarF(int item)
        {
            nodo auxiliar = new nodo(); //nodo temporal que todavia no pertenece a la lista
            auxiliar.dato = item; //almacena en el atributo dato el valor recibido en el parametro
            auxiliar.siguiente = null; //hace que el apuntador señale a null

        if(inicio == null) //verificia si la lista esta vacia
        {
        inicio = auxiliar; //hacemos que nodo sea parte de la lista, lo hacemos cabeza
        }
        else
        {
        nodo puntero; //utilizamos este nodo para recorrer la lista, asi no se mueve la cabeza
        puntero = inicio; //situamos a puntero señalado al mismo nodo que incio
        while(puntero.siguiente!=null)
        {
        puntero = puntero.siguiente; //se desplaza por todos los nodos de la lista        
        }
        puntero.siguiente = auxiliar; //hacemos que ultimo nodo ahora señale al auxiliar
        }
    }

    //metodo para insertar al inicio (insertar en la cabeza)
    public void InsertarI(int item)
    {
    nodo auxiliar = new nodo(); //nodo temporal que despues se agrega a la lista

    auxiliar.dato = item; //almacena valor en el atributo dato
    auxiliar.siguiente = null; //hacemos que puntero siguiente señale a null

    if(inicio == null)
    {
    inicio = auxiliar; //al estar vacia la cola lo hacemos cabeza
    }
    else
    {
    nodo puntero; //para recorrer la lista
    puntero = inicio; //dos apuntadores señalando al mismo nodo
    inicio = auxiliar; //asignamos como cabeza al nodo auxiliar
    auxiliar.siguiente = puntero; //el puntero de auxiliar que ahora es cabeza se enlaza
                                  //con el nodo que era antes la cabeza y que tiene apuntador puntero
    }
    }


    //metodo para eliminar nodo que esta a la cabeza de la lista
    public void EliminarI()
    {
    if(inicio == null) //cuando la lista este vacia
    { Console.WriteLine("Lista vacía, no se puede eliminar elemento"); }
    else
    { inicio = inicio.siguiente; //a quien estaba señalando incio sera nuevo inicio
    }
    }

    //metodo para eliminar nodo al final de la lista
    public void EliminarF()
    {
        if(inicio == null) //cuando la lista este vacia
        { Console.WriteLine("Lista vacia, no se puede eliminar elemento"); }
        else
        {
            nodo punteroant, punteropost; //requiero dos punteros para mover porque no declaré la cola
            punteroant = inicio; //inicializo ambos en la cabeza de la lista
            punteropost = inicio;

            while (punteropost.siguiente != null) //mientras puntero posterior no señale a null
            {
            punteroant = punteropost; //el puntero anterior será a quien señale el posterior
            punteropost = punteropost.siguiente; //puntero posterior sera a quien señalaba antes el posterior
            }
            punteropost.siguiente = null; //con esto sacamos el que estaba al final de la lista, el ultimo nodo
                                      //era el que estaba señalando el punteropost pero ahora el ultimo será
                                      //en donde se quedó punteroant
        }
    }

    //metodo para insertar en una posicion especifica de la lista
    public void InsertarP(int item, int pos)
    {
    nodo auxiliar = new nodo(); //definicion de nuevo nodo con sus atributos
    auxiliar.dato = item;
    auxiliar.siguiente = null;

    if (inicio == null) //si lista está vacia
    {
    Console.WriteLine("La lista está vacia, por lo tanto se va a insertar en la 1ra posición");
    inicio = auxiliar; //inserto nodo
    }

    else
    {
    nodo puntero;
    puntero = inicio; //para recorrer lista
    if(pos ==1) //si la posicion que pidieron es la 1, se inserta en la cabeza
    {
    inicio = auxiliar;
    auxiliar.siguiente = puntero;
    }

    else //si la posicion solicitada no es la 1
    {
        for(int i=1; i<pos-1; i++)
        {
        puntero = puntero.siguiente;
        if (puntero.siguiente == null) //si llegamos al final de la lista
        break;
        }

    nodo punteronext;//apuntador de ayuda
    punteronext = puntero.siguiente; //a quien señalaba el puntero ahi se ubicará el apuntador punteronext
    puntero.siguiente = auxiliar; //ahora el apuntador puntero señalará al nodo auxiliar (el nuevo)
    auxiliar.siguiente = punteronext; //el nodo recien ingresado señalará a punteronext
    //con estas 4 lineas anteriores es cómo se corta momentaneamente la lista y luego se une de nuevo
    }
    }
    }
  
    //método que muestra el contenido de la lista
    public void mostrar()
    {
        if(inicio == null) //si la lista está vacia
        { Console.WriteLine("La lista está vacía"); }
        else
        {
                nodo puntero;
                puntero = inicio; //inicializamos a puntero en el mismo nodo que la cabeza;
                Console.Write("{0} -> \t", puntero.dato); //imprimir valor de nodo. Write y no WriteLine
                while(puntero.siguiente!=null)
                {
                    puntero = puntero.siguiente;
                    Console.Write("{0} -> \t", puntero.dato); //usar Write para que no salte de linea
                }
            }
        Console.WriteLine();
    }
} //fin de la clase lista
}
