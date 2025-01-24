using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVehiculoAbstracto
{
    internal class Coche:Vehiculo
    {
        int puertas;
        public Coche(string marca, string modelo, string color, int potencia, int peso, int puertas) : base(marca, modelo, color, potencia, peso, 4)
        {
            this.puertas = puertas;
        }

        public override void Acelerar()
        {
            Console.WriteLine("Coche acelerando");
        }

        public override void Frenar()
        {
            Console.WriteLine("Coche frenando");
        }

        public override string ToString()
        {
            return $"   Coche\n" + base.ToString() + $"\nPuertas: {puertas}\n";
        }

    }
}
