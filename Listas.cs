using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ejercicios
{
    class Listas
    {
        static public void Pepito()
        {
            List<string> lista = new List<string>();

            lista.Add("Agente 47");
            lista.Add("Max Payne");
            lista.Add("Geralt of Rivia");

            List<string> lista02 = new List<string>() 
            {
                "Juan",
                "Paco",
                "Pedro",
                "De La Mar"
            };

            lista02.Add("Es mi nombre asi");

            lista.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("****************************************");
            foreach (var item in lista02) { Console.WriteLine(item); }
            Console.WriteLine("****************************************");
            
            lista.Insert(0,"Jaden Korr");

            //lista.Remove("Max Payne");

            lista02.RemoveAt(4);

            lista.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("****************************************");

            lista02.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("****************************************");

            lista02.RemoveAll(nombre => {
                if (nombre.StartsWith("P")) return true;
                else return false;
            });

            lista02.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("****************************************");

            lista.Add("Sam Fisher");
            lista.Add("Ezio Auditore da Firenze");

            lista.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("****************************************");

            lista.Sort();

            lista.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("****************************************");

            lista.Reverse();

            lista.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("****************************************");

            // Probando distintas formas de busqueda
            Console.WriteLine("****************************************");

            Persona persona01 = new Persona();
            persona01.Nombre = "Eliseo";

            Persona persona02 = new Persona();
            persona02.Nombre = "Eliseo";

            List<Persona> personas = new List<Persona>();

            personas.Add(persona01);

            Console.WriteLine(personas.Contains(persona01));
            Console.WriteLine(personas.Contains(persona02));

            Console.WriteLine(personas.Any(a => a.Nombre == persona01.Nombre));
            Console.WriteLine(personas.Any(a => a.Nombre == persona02.Nombre));
        }
    }
}
