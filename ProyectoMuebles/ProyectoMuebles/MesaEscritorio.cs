using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuebles
{
    internal class MesaEscritorio:Mesa
    {
        int numeroCajones;

        public MesaEscritorio(int anchura, int altura, string material, string materialPatas, int numeroCajones) :base(anchura, altura, material, materialPatas)
        {
            this.numeroCajones = numeroCajones;
        }

        public int GetNumeroCajones()
        {
            return numeroCajones;
        }

        public void SetNumeroCajones(int numeroCajones)
        {
            this.numeroCajones = numeroCajones;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {numeroCajones}";
        }
    }
}
