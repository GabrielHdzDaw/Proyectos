using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDispositivosIComparableIComparer
{
    internal class Tablet : Tactil
    {
        public Tablet(string nombre, int velocidadProceso, double tamanoPantalla) : base(nombre, velocidadProceso, tamanoPantalla)
        {
        }
        public override void Conectar()
        {
            Console.WriteLine("Tablet conectado");
        }
    }
}
