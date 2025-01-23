using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCasa
{
    internal class Persona
    {
        string nombre;
        Casa casa;

        public Persona(string nombre)
        {
            this.nombre = nombre;
            casa = new Casa(0);
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public Casa GetCasa()
        {
            return casa;
        }

        public void SetCasa(Casa casa)
        {
            this.casa = casa;
        }

        public override string ToString()
        {
            return $"Soy {nombre}. Vivo en una casa de {casa.GetArea()} m2 con una puerta {casa.GetPuerta().GetColor()}.";
        }
    }
}
