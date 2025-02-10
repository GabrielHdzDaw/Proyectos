using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFlota
{
    internal abstract class Vehiculo : Elemento, IComparable<Vehiculo>
    {
        int x;
        int y;
        public Vehiculo(string nombre, bool activo, int x, int y) : base(nombre, activo)
        {
            this.x = x;
            this.y = y;
        }

        public Vehiculo(string nombre) : base(nombre)
        {
            x = 0;
            y = 0;
        }
        public int GetX()
        {
            return x;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public int GetY()
        {
            return y;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public override void Activar()
        {
            SetActivo(true);
        }
        public override void Desactivar()
        {
            SetActivo(false);
        }

        public abstract void Mover(int x, int y);
        
        public int CompareTo(Vehiculo? vehiculo)
        {
            if (vehiculo == null) return 1;
            return GetNombre().CompareTo(vehiculo.GetNombre());
        }

        public override string ToString()
        {
            return base.ToString() + $"Coordenadas: {x},{y}";
        }
    }
}
