using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmulator
{
    internal class ProcesadorZ80: Procesador
    {
        public ProcesadorZ80(double velocidad) : base(8, velocidad, "A B C D E F H L")
        {
        }

        public override void MostrarOrdenes()
        {
            Console.Write("Z80: ");
            base.MostrarOrdenes();
        }
    }
}
