using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCasa
{
    internal class Casa
    {
        double area;
        Puerta puerta;

        public Casa(double area)
        {
            this.area = area;
            puerta = new Puerta();
        }

        public double GetArea()
        {
            return area;
        }

        public void SetArea(double area)
        {
            this.area = 0;
        }

        public Puerta GetPuerta()
        {
            return puerta;
        }

        public override string ToString()
        {
            return $"Soy una casa, mi área es de {area}m2";
        }
    }
}
