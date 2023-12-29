using System;
using System.Text;
using System.Security.Cryptography;

namespace ejercicios
{
    class Encriptados
    {
        static public void Pepito()
        {
            /*Console.WriteLine("Mandale una pass o la poronga que quieras encriptar: ");
            string mensaje = Console.ReadLine();
            string mensaEncri = EncriptarBase64(mensaje);
            Console.WriteLine("Mnsaje encriptado:");
            Console.WriteLine(mensaEncri);

            Console.WriteLine("Jeje, ahora lo vamos a desencriptar, fijate si quedo igualito.");
            string mensaDesencri = DesencriptarBase64(mensaEncri);
            Console.WriteLine(mensaDesencri);*/

            Console.WriteLine("Mandale una pass o la poronga que quieras encriptar: ");
            string mensaje = Console.ReadLine();
            string mensaEncri = EncriptarMD5(mensaje);
            Console.WriteLine("Mnsaje encriptado:");
            Console.WriteLine(mensaEncri);

            Console.WriteLine("Jeje, ahora lo vamos a desencriptar, fijate si quedo igualito.");
            string mensaDesencri = DesencriptarMD5(mensaEncri);
            Console.WriteLine(mensaDesencri);

        }

        static string EncriptarBase64(string mensaje)
        {
            string resultado = string.Empty;
            byte[] encriptado = System.Text.Encoding.Unicode.GetBytes(mensaje);
            resultado = Convert.ToBase64String(encriptado);
            return resultado;
        }

        static string DesencriptarBase64(string mensaje)
        {
            string resultado = string.Empty;
            byte[] desencriptado = Convert.FromBase64String(mensaje); 
            resultado = System.Text.Encoding.Unicode.GetString(desencriptado);
            return resultado;
        }

        static string EncriptarMD5(string mensaje)
        {
            string hash = "Zenitram";
            byte[] data = UTF8Encoding.UTF8.GetBytes(mensaje);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateEncryptor();
            byte[] resultado = transform.TransformFinalBlock(data,0,data.Length);

            return Convert.ToBase64String(resultado);
        }

        static string DesencriptarMD5(string mensaje)
        {
            string hash = "Zenitram";
            byte[] data = Convert.FromBase64String(mensaje);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateDecryptor();
            byte[] resultado = transform.TransformFinalBlock(data,0,data.Length);

            return UTF8Encoding.UTF8.GetString(resultado);
        }
    }
}