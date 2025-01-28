using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnimalAbstracto
{
    internal abstract class Ave : Animal
    {
        public Ave(string nombre, int edad) : base(nombre, edad)
        {
        }

        public abstract void Volar();
    }
}
