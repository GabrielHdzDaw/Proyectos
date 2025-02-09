using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCabanas
{
    internal class Cabana
    {
        string nombre;
        int edad;
        Persona[] componentes;

        public Cabana(string nombre, int edad, Persona[] componentes)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.componentes = componentes;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetEdad()
        {
            return edad;
        }

        public Persona[] GetComponentes()
        {
            return componentes;
        }


        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public void SetComponentes(Persona[] componentes)
        {
            this.componentes = componentes;
        }
    }
}
