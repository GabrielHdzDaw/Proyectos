using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema7
{
    internal class Dron: Vehiculo
    {
        int z;

        public Dron(string nombre, int x, int y, int z, bool estado, int bateria):base(nombre, x, y, estado, bateria)
        {
            this.z = z;
        }

        public int GetZ() { return z; }
        public void SetZ(int z)
        {
            this.z = z;
        }

        public void Mover(int x, int y, int z)
        {
            SetX(x); SetY(y); SetZ(z);
        }

        public void ReconocimientoAereo()
        {
            Console.WriteLine($"Sobrevolando ({GetX()}, {GetY()}, {z})");
        }

        public override string ToString()
        {
            return base.ToString() + $"Altitud: {z} ";
        }
    }
}
