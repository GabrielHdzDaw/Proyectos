using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFlota
{
    internal class Auto:Vehiculo
    {
        public Auto(string nombre, bool activo, int x, int y) : base(nombre, activo, x, y)
        {
        }

        public Auto(string nombre) : base(nombre)
        {
            SetX(0);
            SetY(0);
        }   
        public override void Mover(int x, int y)
        {
            SetX(x);
            SetY(y);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
