using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnimales
{
    internal class Perro:Animal
    {
        public Perro(string nombre) : base(nombre) { }

        public virtual void Ladrar()
        {
            Console.WriteLine($"({nombre}) Guau!");
        }

        public override void Hablar()
        {
            Console.WriteLine($"({nombre}) Guau!");
        }
    }
}
