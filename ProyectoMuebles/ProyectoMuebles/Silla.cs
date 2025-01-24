using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuebles
{
    internal class Silla:Mueble
    {
        bool ruedas;

        public Silla(int anchura, int altura, string material, bool ruedas) :base(anchura, altura, material)
        {
            this.ruedas = ruedas;
        }

        public bool GetRuedas()
        {
            return ruedas;
        }

        public void SetRuedas(bool ruedas)
        {
            this.ruedas = ruedas;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {ruedas}";
        }
    }
}
