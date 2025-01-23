using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico
{
    internal class Zoologico
    {
        Animal[] animales;

        public Zoologico(Animal[] animales)
        {
            this.animales = animales;
        }

        public override string ToString()
        {
            string datos = "";
            for (int i = 0; i < animales.Length; i++)
            {
                datos += animales[i] + "\n";
            }
            return datos;
        }
    }
}
