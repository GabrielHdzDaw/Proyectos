using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersona
{
    internal class PersonaInglesa:Persona
    {

        public PersonaInglesa() : base("Jhon") { }

        public PersonaInglesa(string nombre) : base() 
        {
            base.SetNombre(nombre);
        }

        public void TomarTe()
        {
            Console.WriteLine("Estoy tomando té.");
        }

        public override void Saludar()
        {
            Console.WriteLine($"Hi, I am {base.nombre}");
        }
    }
}
