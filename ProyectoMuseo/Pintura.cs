using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseo
{
    internal class Pintura: Obra
    {
        public Pintura(string autor, string propietario, string nombre, int año) : base(autor, propietario, nombre, año)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
