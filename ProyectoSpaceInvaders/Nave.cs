using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSpaceInvaders
{
    internal class Nave:Sprite
    {
        public Nave():base(500, 600, "/\\")
        {
            Console.WriteLine("Creando nave en posición prefijada");
        }

        public Nave(int x, int y) : base(x, y, "/\\")
        {
            Console.WriteLine("Creando nave en posición indicada por el usuario");
            this.x = x;
            this.y = y;
        }
        public void MoverDerecha()
        {
            base.SetX(base.GetX() + 10);
        }

        public void MoverIzquierda()
        {
            base.SetX(base.GetX() - 10);
        }
    }
}
