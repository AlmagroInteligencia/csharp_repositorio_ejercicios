using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class Persona
    {
        private string nombre;
        private string edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Edad { get => edad; set => edad = value; }

        public Persona()
        {

        } 

        public virtual string Saludar()
        {
            return $"Hola, soy {nombre}";
        }

        public override bool Equals(object obj)
        {
            var p = obj as Persona;
            if (p != null)
            {
                return p.Nombre == Nombre;
            }
            return false;
        }
    }
}
