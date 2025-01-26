using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersona
{
    internal class PersonaItaliana:Persona
    {
        public PersonaItaliana():base() 
        {
            
        }
        public override void Saludar()
        {
            Console.WriteLine("Ciao");
        }
    }
}
