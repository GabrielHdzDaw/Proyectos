using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmulator
{
    internal class Procesador6502: Procesador
    {
        public Procesador6502(double velocidad): base(8, velocidad, "A X Y")
        {
        }
        public override void MostrarOrdenes()
        {
            Console.Write("Z80: ");
            base.MostrarOrdenes();
        }
    }
}
