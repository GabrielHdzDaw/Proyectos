using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnimalAbstracto
{
    internal abstract class Animal
    {
        string nombre;
        public Animal(string nombre)
        {
            this.nombre = nombre;   
        }

        public abstract void Hablar();
    }
}
