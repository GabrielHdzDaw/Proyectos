using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSpaceInvaders
{
    internal class Partida
    {
        public void Lanzar()
        {
            Nave nave = new Nave();
            Enemigo enemigo = new Enemigo();
            Console.WriteLine("Esta sería la pantalla de juego. Pulse ESC para salir");
            nave.SetX(500);
            nave.SetY(600);
            
            enemigo.SetX(100);
            enemigo.SetY(80);
            
            ConsoleKeyInfo tecla = Console.ReadKey();
            do
            {
                Console.Clear();
                nave.Dibujar();
                enemigo.Dibujar();
                switch (tecla.Key)
                {
                    case ConsoleKey.LeftArrow:
                        nave.MoverIzquierda();
                        break;
                    case ConsoleKey.RightArrow:
                        nave.MoverDerecha();
                        break;
                }
            } while (tecla.Key != ConsoleKey.Escape);
            Console.Clear();
        }
    }
}
