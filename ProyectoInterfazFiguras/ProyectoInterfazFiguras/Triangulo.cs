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
        public Triangulo(int x1, int x2, int y1, int y2) : base(x1, x2, y1, y2) { }

        public int GetTamano()
        {
            return ((x2 - x1) * (y2 - y1)) / 2;
        }

        public void Dibujar()
        {
            //Console.SetCursorPosition(x1, y1);
            for (int i = 0; i < y2 - y1; i++)
            {
                for (int j = 0; j <= i; j++)
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
