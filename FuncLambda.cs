using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class FuncLambda
    {
        static public void Pepito()
        {
            Func<int, int> func1 = x => x + 5;
            Func<int, string> func2 = x => (x * 2).ToString();

            Console.WriteLine(func1(20));
            Console.WriteLine(func2(333));

            Console.WriteLine(FuncionTradicional(47));

            var func3 = (string saludo, string nombre) => saludo + " " + nombre;
            // string func4 = (string saludo, string nombre) => saludo + " " + nombre; // tira error

            Console.WriteLine(func3("Ehhh", "Cahcho"));
            Console.WriteLine(Saludar("Que hacee", "Tito"));

            Func<int, int> NumeroMasUno = x => x + 1;

            //int Suma(Func<int, int> numero, int numero2) {return numero(5) + numero2;}

            Console.WriteLine(Suma(NumeroMasUno,6));

            Action<string> printf = texto => Console.WriteLine(texto);

            printf("Mirá pibe, estoy poniendo esto en pantalla");

        }

        static int FuncionTradicional(int numero) 
        {
            return numero * 10;
        }

        static string Saludar(string saludo, string nombre)
        {
            return $"{saludo} {nombre}";
        }

        static int Suma(Func<int, int> numero, int numero2) 
        {
            return numero(5) + numero2;
        }
    }
}
