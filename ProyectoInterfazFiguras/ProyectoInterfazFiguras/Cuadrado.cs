using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInterfazFiguras
{
    internal class Cuadrado:FiguraG, IMedible, IDibujable
    {
        public Cuadrado(int x1, int x2, int y1, int y2) : base(x1, x2, y1, y2) { }

        public int GetTamano()
        {
            return (x2 - x1) * (y2 - y1);
        }

        public void Dibujar()
        {
            //Console.SetCursorPosition(x1, y1);
            for (int i = 0; i < y2 - y1; i++)
            {
                for (int j = 0; j < x2 - x1; j++)
                {
                    if (i == 0 || i == (y2 - y1) - 1 || j == 0 || j == (x2 - x1) - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Cuadrado {GetTamano()}");
        }
    }
}
