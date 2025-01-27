using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInterfazFiguras
{
    internal abstract class FiguraG
    {
        protected int x1, y1;
        protected int x2, y2;

        public FiguraG(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public FiguraG(): this(0,0,0,0)
        {

        }

        public abstract void Mostrar();
    }
}
