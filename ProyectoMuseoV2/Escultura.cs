using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoV2
{
    internal class Escultura: Obra, IComparable<Obra>
    {
        string material;
        

        public Escultura(Autor autor, string propietario, string nombre, int ano, string material) : base(autor, propietario, nombre, ano)
        {
            this.material = material;
        }

        public string GetMaterial()
        {
            return material;
        }

        

        public void SetMaterial(string material)
        {
            this.material = material;
        }

        

        public int CompareTo(Obra obra)
        {
            return GetAno().CompareTo(obra.GetAno());
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMaterial: {material}";
        }
    }
    
}
