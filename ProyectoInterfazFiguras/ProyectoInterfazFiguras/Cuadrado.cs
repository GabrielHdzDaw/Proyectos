using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInterfazFiguras
{
    internal class Cuadrado:FiguraG, IMedible, IDibujable
    {
        public Cuadrado() : base() { }

        public int GetTamano()
        {
            return (x2 - x1) * (y2 - y1);
        }

        public void Dibujar()
        {

        }

        public override void Mostrar()
        {
            Console.WriteLine($"Cuadrado {GetTamano()}");
        }
    }
}
