using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico {
    internal class Pez:Animal
    {
        public Pez() : base("pez", "carnivoro", new Habitat("océano"))
        {
            
        }
    }
}
