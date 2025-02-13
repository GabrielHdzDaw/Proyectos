using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema7
{
    internal class Vehiculo: Elemento, IRecargable, IMovible
    {
        int bateria;

        public Vehiculo(string nombre, int x, int y, bool estado, int bateria):base(nombre, x, y, estado)
        {
            this.bateria = bateria;
        }

        public int GetBateria()
        {
            return bateria;
        }

        

        public void SetBateria(int bateria)
        {
            this.bateria = bateria;
        }

        

        public void Recargar()
        {
            SetBateria(100);
        }

        public void MoverEstacionRecarga(EstacionRecarga estacion)
        {
            Mover(estacion.GetX(), estacion.GetY());
            Recargar();
        }

        public void Mover(int x, int y)
        {
            SetX(x);
            SetY(y);
            SetBateria(GetBateria() - 10);
            if (bateria < 20)
            {

            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Batería: {bateria} ";
        }
    }
}
