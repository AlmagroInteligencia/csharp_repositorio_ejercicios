using System;
using System.Collections;

namespace ejercicios
{
    class Colas 
    {
        static public void Pepito(/*string[] args*/) 
        {
            
            Queue fila = new Queue();

            fila.Enqueue("Juan");
            fila.Enqueue("Favalli");
            fila.Enqueue("Franco");

            Queue filaClon = (Queue)fila.Clone();

            Console.WriteLine("Cantidad de elementos en fila: " + fila.Count);
            Console.WriteLine("Cantidad de elementos en filaClon: " + filaClon.Count);

            foreach(string item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Cantidad de elementos en fila: " + fila.Count);
            Console.WriteLine("Cantidad de elementos en filaClon: " + filaClon.Count);

            while (fila.Count > 0)
            {
                Console.WriteLine(fila.Dequeue());
            }

            Console.WriteLine("Cantidad de elementos en fila: " + fila.Count);
            Console.WriteLine("Cantidad de elementos en filaClon: " + filaClon.Count);

            foreach(string item in filaClon)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Cantidad de elementos en filaClon: " + filaClon.Count);

            Console.WriteLine(filaClon.Peek());

            filaClon.Clear();

            Console.WriteLine("Cantidad de elementos en filaClon: " + filaClon.Count);

        }
    }
}