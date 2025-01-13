using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersona
{
    internal class PruebaPersona3
    {
        public static void Main()
        {
            PersonaInglesa personaInglesa = new PersonaInglesa("Jimmy");
            PersonaItaliana personaItaliana = new PersonaItaliana("Federico");

            personaInglesa.Saludar();
            personaItaliana.Saludar();

        }
    }
}
