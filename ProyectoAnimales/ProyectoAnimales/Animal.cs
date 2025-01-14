using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnimales
{
    internal class Animal
    {
        protected string nombre;

        public Animal(string nombre) 
        {
            this.nombre = nombre;
        }

        public Animal():this("") { }

        public virtual void Hablar()
        {
            Console.WriteLine($"");
        }
    }
}
