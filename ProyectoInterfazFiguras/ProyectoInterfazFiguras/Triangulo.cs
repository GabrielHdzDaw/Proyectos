using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInterfazFiguras
{
    internal class Triangulo:FiguraG, IMedible, IDibujable
    {
        public Triangulo() :base() { }

        public int GetTamano()
        {
            return ((x2 - x1) * (y2 - y1)) / 2;
        }

        public void Dibujar()
        {
            for (int i = 0; i < y2 - y1; i++)
            {
                for (int j = 0; j < x2 - x1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Triangulo {GetTamano()}");
        }
    }
}
