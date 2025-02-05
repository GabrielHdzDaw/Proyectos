using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDomotica
{
    internal class Toldo : Persiana
    {
        public Toldo(string nombre, int apertura) : base(nombre, apertura)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"{GetApertura()}% abierta";
        }
    }
}