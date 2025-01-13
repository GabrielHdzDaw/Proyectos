using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSpaceInvaders
{
    internal class Bienvenida
    {

        bool salir = false;


        public bool GetSalir()
        {
            return salir;
        }
        public void Lanzar()
        {
            
            Console.WriteLine("Bienvenido a Console Invaders. Pulse Intro para jugar o ESC para salir");
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Escape) salir = true;
        }
    }
}
