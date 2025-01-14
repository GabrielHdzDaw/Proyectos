using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnimales
{
    internal class PerroEnfadado:Perro
    {
        public PerroEnfadado(string nombre) : base(nombre) { }
        public override void Ladrar()
        {
            Console.WriteLine($"({nombre}) Grrr!");
        }

        public override void Hablar()
        {
            Console.WriteLine($"({nombre}) Grrr!"); ;
        }
    }
}
