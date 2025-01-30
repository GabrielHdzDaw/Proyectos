using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDispositivosIComparableIComparer
{
    internal class Tactil: Dispositivo, ILocaliza
    {
        public Tactil(string nombre, int velocidadProceso, double tamanoPantalla) : base(nombre, velocidadProceso, tamanoPantalla)
        {
        }
        public override void Conectar()
        {
            Console.WriteLine("Dispositivo táctil conectado");
        }

        public void ActivarGPS()
        {
            Console.WriteLine($"GPS del dispositivo {GetNombre()} activado");
        }

        public void DesactivarGPS()
        {
            Console.WriteLine($"GPS del dispositivo {GetNombre()} desactivado");
        }

    }
    
}
