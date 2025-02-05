using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDomotica
{
    internal class Persiana : Dispositivo, ISubible
    {
        int apertura;
        public Persiana(string nombre, int apertura) : base(nombre)
        {
            this.apertura = apertura > 100 ? 100 : apertura < 0 ? 0 : apertura;
        }

        public int GetApertura()
        {
            return apertura;
        }

        public void Subir()
        {
            apertura = 100;
        }

        public void Bajar()
        {
            apertura = 0;
        }

        public void Subir(int porcentaje)
        {
            apertura = apertura + porcentaje > 100 ? 100 : apertura + porcentaje;
        }

        public void Bajar(int porcentaje)
        {
            apertura = apertura - porcentaje < 0 ? 0 : apertura - porcentaje > 100 ? 100 : apertura - porcentaje;
        }

        public override string ToString()
        {
            return base.ToString() + apertura + "% abierta";

        }
    }
}
