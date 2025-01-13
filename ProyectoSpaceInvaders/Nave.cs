using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSpaceInvaders
{
    internal class Nave:Sprite
    {
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
