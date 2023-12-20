// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Diagnostics;

namespace ejercicios
{
    class Basicos 
    {
        
        static int ingresarNumero() 
        {
            Console.WriteLine("mandale un numerito: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        
        static int calcularMayor(int num1, int num2, int num3) 
        {
            int mayor = 0;
            if(num1 >= num2 && num1 >= num3) mayor = num1;
            else if(num2 >= num3 && num2 >= num1) mayor = num2;
            else if(num3 >= num1 && num3 >= num2) mayor = num3;
            else if(num1 >= num3 && num2 >= num3 && num1 >= num2) mayor = num1;
            else if(num1 >= num3 && num2 >= num3 && num2 >= num1) mayor = num2;
            else if(num3 >= num1 && num2 >= num1 && num3 >= num2) mayor = num2;
            return mayor;
        }
        
        static int calcularMenor(int num1, int num2, int num3) 
        {
            int menor = 0;
            if(num1 <= num2 && num1 <= num3) menor = num1;
            else if(num2 <= num3 && num2 <= num1) menor = num2;
            else if(num3 <= num1 && num3 <= num2) menor = num3;
            else if(num1 <= num3 && num2 <= num3 && num1 <= num2) menor = num1;
            else if(num1 <= num3 && num2 <= num3 && num2 <= num1) menor = num2;
            else if(num3 <= num1 && num2 <= num1 && num3 <= num2) menor = num2;
            return menor;
        }

        static double calcularPromedio(int num1, int num2, int num3) 
        {
            return (Convert.ToDouble(num1) + Convert.ToDouble(num2) + Convert.ToDouble(num3)) / 3;
        }

        static bool esPar(int num) 
        {
            if (num % 2 == 0) return true;
            else return false;
        }

        static bool esPrimo(int num) 
        {
            if (num == 0 || num == 1) return false;
            if (num == 2) return true;
            for (int i = 2; i < num; i++) {   
                if (num % i == 0) return false;
            }
            return true;
        }

        static public void Pepito(/*string[] args*/) 
        {

            //Console.WriteLine("mandale un numerito: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("mandale otro numerito: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("mandale otro numerito más: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int menor = 0, mayor = 0;

            /*if(num1 <= num2) {
                if(num1 <= num3) menor = num1;
                else if(num2 >= num3) mayor = num2;
                else if(num3 <= num1) menor = num3;
            }*/
            
            
            // Para mayor

            //if(num1 >= num2 && num1 >= num3) mayor = num1;
            //else if(num2 >= num3 && num2 >= num1) mayor = num2;
            //else if(num3 >= num1 && num3 >= num2) mayor = num3;
            //else if(num1 >= num3 && num2 >= num3 && num1 >= num2) mayor = num1;
            //else if(num1 >= num3 && num2 >= num3 && num2 >= num1) mayor = num2;
            //else if(num3 >= num1 && num2 >= num1 && num3 >= num2) mayor = num2;


            // Para menor

            //if(num1 <= num2 && num1 <= num3) menor = num1;
            //else if(num2 <= num3 && num2 <= num1) menor = num2;
            //else if(num3 <= num1 && num3 <= num2) menor = num3;
            //else if(num1 <= num3 && num2 <= num3 && num1 <= num2) menor = num1;
            //else if(num1 <= num3 && num2 <= num3 && num2 <= num1) menor = num2;
            //else if(num3 <= num1 && num2 <= num1 && num3 <= num2) menor = num2;
            
            // ejercicios, usando funciones
            
            
            // Ingresar 3 numeros
            int num1 = ingresarNumero();
            int num2 = ingresarNumero();
            int num3 = ingresarNumero();

            // Calcular mayor y menor
            int mayor = calcularMayor(num1, num2, num3);
            int menor = calcularMenor(num1, num2, num3);

            // Calcular promedio
            double promedio = calcularPromedio(num1, num2, num3);

            // Verificar si es par
            Console.WriteLine((esPar(num1)) ? num1 + " es par" : num1 + " es impar");
            Console.WriteLine((esPar(num2)) ? num2 + " es par" : num2 + " es impar");
            Console.WriteLine((esPar(num3)) ? num3 + " es par" : num3 + " es impar");

            // Mostrar salidas
            Console.WriteLine("el número menor es: " + menor);
            Console.WriteLine("el número mayor es: " + mayor);
            Console.WriteLine("el promedio es: " + promedio);

            // Jercicio tienda
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Querés comprar algo? si/no");
            string respuesta = Console.ReadLine();
            if (respuesta == "s" || respuesta == "S" || respuesta == "Si" || respuesta == "si") 
            {
                Console.WriteLine("Joya, tengo esto:");
                Console.WriteLine("1- Lompa: $10000");
                Console.WriteLine("2- Remera: $8000");
                Console.WriteLine("3- Zapas: $45000");
                int coso = Convert.ToInt32(Console.ReadLine());
                if (coso == 1) 
                {
                    Console.WriteLine("Piola, te llevás el lompa.");
                    Console.WriteLine("Tenés un cupón? mandalo a ver si te sirve: ");
                    double precio = 10000;
                    string cupon = Console.ReadLine();
                    if (cupon == "NAVIDAD") 
                    {
                        precio = precio * 0.9;
                        Console.WriteLine("Muy bien, entonces serían $" + precio);
                    } else 
                    {
                        Console.WriteLine("Eso que tiraste no te sirve un joraca, no hay descuento.");
                    }
                }
                if (coso == 2) 
                {
                    Console.WriteLine("Piola, te llevás la remera.");
                    Console.WriteLine("Tenés un cupón? mandalo a ver si te sirve: ");
                    double precio = 8000;
                    string cupon = Console.ReadLine();
                    if (cupon == "NAVIDAD") 
                    {
                        precio = precio * 0.9;
                        Console.WriteLine("Muy bien, entonces serían $" + precio);
                    } else 
                    {
                        Console.WriteLine("Eso que tiraste no te sirve un joraca, no hay descuento.");
                    }
                }
                if (coso == 3) 
                {
                    Console.WriteLine("Piola, te llevás las zapas.");
                    Console.WriteLine("Tenés un cupón? mandalo a ver si te sirve: ");
                    double precio = 45000;
                    string cupon = Console.ReadLine();
                    if (cupon == "NAVIDAD") 
                    {
                        precio = precio * 0.9;
                        Console.WriteLine("Muy bien, entonces serían $" + precio);
                    } else 
                    {
                        Console.WriteLine("Eso que tiraste no te sirve un joraca, no hay descuento.");
                    }
                }
                else Console.WriteLine("No pibe, tiraste cualquiera... Aprendé los numeritos y volvé.");
            }
            else Console.WriteLine("Entonces no me rompás las pelotas, rajá de acá Pibe!");
            

            // Numeros primos 
            Console.WriteLine("Los primeros 100 números primos:");
            int conta = 0;
            /*for (int i = 0; i < 10000; i++) {
                if (conta == 100) break;
                if(esPrimo(i)) {
                    Console.WriteLine(i);
                    conta++;
                }
            }*/
            
            int numero = 2;
            while (conta < 100) 
            {
                if(esPrimo(numero)) 
                {
                    Console.WriteLine(numero);
                    conta++;
                }
                numero++;
            }
            
        }
    }
}


