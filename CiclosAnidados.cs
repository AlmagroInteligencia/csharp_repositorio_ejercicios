using System;
using System.Collections.Generic;

namespace ejercicios
{
    class Ciclos
    {
        static public void Pepito()
        {
            List<string> lista = new List<string>()
            {
                "Menem",
                "Cavallo",
                "De la Rua",
                "Duhalde"
            };

            List<string> lista02 = new List<string>() 
            {
                "Menem",
                "Cavallo",
                "De la Rua",
                "Duhalde",
                "Menem",
                "Menem",
                "Cavallo",
                "Duhalde"
            };

            for (int i = 0; i < lista.Count; i++)
            {
                int contador = 0;
                for (int h = 0; h < lista02.Count; h++)
                {
                    if (lista[i] == lista02[h]) contador++;
                }
                Console.WriteLine($"El señor {lista[i]} aparece {contador} veces");
            }

        }
    }
}
