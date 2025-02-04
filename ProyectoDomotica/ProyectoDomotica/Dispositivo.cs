using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDomotica
{
    internal abstract class Dispositivo
    {
        string nombre;

        public Dispositivo(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre} ";
        }
    }
}
