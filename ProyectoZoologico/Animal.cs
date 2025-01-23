using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico
{
    internal class Animal
    {
        protected string nombre;
        string tipoAlimentacion;
        protected Habitat habitat;

        public Animal(string nombre, string tipoAlimentacion, Habitat habitat )
        {
            this.nombre = nombre;
            this.tipoAlimentacion = tipoAlimentacion;
            this.habitat = habitat;
        }
        public Animal() : this("","", new Habitat()) { }

        public string GetNombre()
        {
            return nombre; 
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetTipoAlimentacion()
        {
            return tipoAlimentacion; 
        }

        public void SetTipoAlimentacion(string tipoAlimentacion)
        {
            this.tipoAlimentacion = tipoAlimentacion;
        }

        public Habitat GetHabitat()
        {
            return habitat;
        }

        public void SetHabitat(string habitat)
        {
            this.habitat = new Habitat(habitat);
        }

        public override string ToString()
        {
            return $"Soy un {nombre} y soy {tipoAlimentacion}. {habitat}";
        }
    }
}
