using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCasa
{
    internal class Puerta
    {
        string color;
        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return $"Soy una puerta, mi color es {color}"; 
        }
    }
}
