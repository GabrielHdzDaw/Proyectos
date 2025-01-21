using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMesa
{
    internal class Pata
    {
        string color;
        string material;

        public Pata(string color, string material)
        {
            this.color = color;
            this.material = material;
        }
        public Pata():this("marrón", "madera") { }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void SetMaterial(string material)
        {
            this.material = material;
        }

        public string GetColor()
        {
            return color;
        }

        public string GetMaterial()
        {
            return material;
        }

        public override string ToString()
        {
            return $" de {material} color {color}";
        }
    }
}
