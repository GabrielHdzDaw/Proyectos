using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSpaceInvaders
{
    internal class Enemigo:Sprite
    {
        public Enemigo(int x, int y):base(x, y, "][")
        {
            this.x = x;
            this.y = y;
        }

        public Enemigo():base(100, 80, "][")
        {

        }
    }
}
