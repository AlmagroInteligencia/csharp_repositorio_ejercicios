using System;

namespace ejercicios
{
    class Recursivas
    {
        static public void Pepito()
        {
            Console.WriteLine("Mandale un numerito para calcular el factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            long resultado = Factorial(numero);

            Console.WriteLine($"El factorial de {numero} es igual a: {resultado}");

        }

        static long Factorial(int numero)
        {
            if(numero == 0) return 0;
            if(numero == 1) return 1;
            else
            {
                return numero * Factorial(numero-1);
            }
        }
    }
}