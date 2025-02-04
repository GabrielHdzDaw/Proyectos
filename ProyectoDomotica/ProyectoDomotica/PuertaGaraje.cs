using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDomotica
{
    internal class PuertaGaraje:Puerta, ISubible
    {
        int apertura;
        public PuertaGaraje(string nombre, bool bloqueado, int apertura) : base(nombre, bloqueado)
        {
            this.apertura = apertura;
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
            apertura = apertura - porcentaje < 0 ? 0 : apertura - porcentaje;
        }

        public override string ToString()
        {
            return base.ToString() + " " + apertura + "% abierta";
        }
    }
}
