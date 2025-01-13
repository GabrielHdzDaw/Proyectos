using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersona
{
    internal class PersonaItaliana:Persona
    {
        public PersonaItaliana(string nombre):base() 
        {
            base.nombre = nombre;
        }
        public override void Saludar()
        {
            Console.WriteLine("Ciao");
        }
    }
}
