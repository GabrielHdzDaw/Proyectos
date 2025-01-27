using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInterfazGeometria
{
    internal class Circulo:IFiguraGeometrica
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double CalcularPerimetro()
        {
            return Math.PI * radio * 2;
        }
    }
}
