using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFlota
{
    internal class RobotReparto:Vehiculo, ICargable
    {
        int porcentajeBateria;
        
        public RobotReparto(string nombre, bool activo, int x, int y, int porcentajeBateria) : base(nombre, activo, x, y)
        {
            this.porcentajeBateria = porcentajeBateria;
            
        }

        public RobotReparto(string nombre) : base(nombre)
        {
            porcentajeBateria = 10;
            SetX(0);
            SetY(0);
        }

        public int GetPorcentajeBateria()
        {
            return porcentajeBateria;
        }

        public void SetPorcentajeBateria(int porcentajeBateria)
        {
            this.porcentajeBateria = porcentajeBateria;
        }

        public override void Mover(int x, int y)
        {
            SetX(x);
            SetY(y);
        }

        public void EnviarACargar(EstacionCarga estacion)
        {
            Mover(estacion.GetX(), estacion.GetY());
            Cargar();
        }

        public void Cargar()
        {
            porcentajeBateria += 50;
            porcentajeBateria = porcentajeBateria > 100 ? 100 : porcentajeBateria;

        }
        public override string ToString()
        {
            return base.ToString() + $" Batería: {porcentajeBateria}";
        }
    }
}
