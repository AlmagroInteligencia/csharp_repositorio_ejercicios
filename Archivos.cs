using System;
using System.IO;

namespace ejercicios
{
    class Archivos
    {
        static public void Pepito()
        {
            
            CrearArchivo("pepito");
            LeerArchivo("pepito");
            ApendearEnArchivo("pepito");
            LeerArchivo("pepito");
            EliminarArchivo("pepito");

        }

        static void CrearArchivo(string nombre)
            {
                TextWriter archivo = new StreamWriter(nombre);
                Console.WriteLine("Mandale fruta pa meter en el archivo:");
                string texto = Console.ReadLine().ToString();
                archivo.WriteLine(texto);
                archivo.Close();
            }

        static void LeerArchivo(string nombre)
            {
                TextReader archivo = new StreamReader(nombre);
                Console.WriteLine(archivo.ReadToEnd());
                archivo.Close();
            }

        static void ApendearEnArchivo(string nombre)
            {
                TextWriter archivo = File.AppendText(nombre);
                Console.WriteLine("Mandale fruta pa meter en el archivo:");
                string texto = Console.ReadLine().ToString();
                archivo.WriteLine(texto);
                archivo.Close();
            }

        static void EliminarArchivo(string nombre)
            {
                File.Delete(nombre);
                Console.WriteLine($"Ha sido eliminado el archivo {nombre}");
            }
    }
}