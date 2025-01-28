using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnimalAbstracto
{
    internal abstract class Animal : IComparable<Animal>
    {
        string nombre;
        int edad;
        public Animal(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetEdad()
        {
            return edad;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int CompareTo(Animal animal)
        {
            return nombre.CompareTo(animal.nombre);
        }

        
        public abstract void Hablar();
        public override string ToString()
        {
            return nombre + " " + edad;
        }
    }
}
