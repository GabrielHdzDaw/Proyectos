using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3d
{
    internal class Punto3D
    {
        int x, y, z;

        public Punto3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void MoveTo(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetZ(int z)
        {
            this.z = z;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetZ()
        {
            return this.z;
        }
        public double DistanceTo(Punto3D p)
        {
            return Math.Sqrt((double)Math.Pow(x - p.x, 2) + (double)Math.Pow(y - p.y, 2) + (double)Math.Pow(z - p.z, 2));
        }

        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }

    }
}
