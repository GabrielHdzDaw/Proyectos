using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseo
{
    internal class Escultura: Obra
    {
        string material;

        public Escultura(string autor, string propietario, string nombre, int año, string material) : base(autor, propietario, nombre, año)
        {
            this.material = material;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMaterial: {material}";
        }
    }
    
}
