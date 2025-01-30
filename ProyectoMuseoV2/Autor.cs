using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoV2
{
    internal class Autor
    {
        string nombre;

        public Autor(string nombre)
        {
            this.nombre = nombre;
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
            return $"Nombre: {nombre}";
        }
    }
}
