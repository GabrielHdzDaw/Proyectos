using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnimalAbstracto
{
    internal class Perro:Animal
    {
        public Perro(string nombre, int edad) : base(nombre, edad) 
        { }
        
        public override void Hablar()
        {
            Console.WriteLine("Guau!");
        }
    }
}
