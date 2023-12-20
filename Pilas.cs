using System;
using System.Collections;

namespace ejercicios
{
    class Pilas
    {
        static public void Pepito()
        {
            Stack pila = new Stack();

            pila.Push("Pipi Romagnoli");
            pila.Push("Papu Gomez");
            pila.Push("Angelito Correa");

            Console.WriteLine("Cantidad de elementos en pila: " + pila.Count);

            foreach(string item in pila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Cantidad de elementos en pila: " + pila.Count);

            //Console.WriteLine(pila.Peek());

            //pila.Clear();

            while (pila.Count > 0)
            {
                Console.WriteLine(pila.Pop());
            }

            Console.WriteLine("Cantidad de elementos en pila: " + pila.Count);
        }
    }
}
