using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico
{
    internal class Habitat
    {
        string nombre;

        public Habitat(string nombre)
        {
            this.nombre = nombre;
        }

        public Habitat() : this("")
        {
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"Vivo en el/la {nombre}.";
        }
    }
}
