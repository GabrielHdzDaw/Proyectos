using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoV2
{
    internal class Pintura: Obra
    {
        public Pintura(Autor autor, string propietario, string nombre, int año) : base(autor, propietario, nombre, año)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
