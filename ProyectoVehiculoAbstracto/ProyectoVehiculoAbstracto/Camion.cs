using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVehiculoAbstracto
{
    internal class Camion:Vehiculo
    {
        public Camion(string marca, string modelo, string color, int potencia, int peso, int ruedas) : base(marca, modelo, color, potencia, peso, ruedas)
        {

        }

        public override void Acelerar()
        {
            Console.WriteLine("Camión acelerando");
        }

        public override void Frenar()
        {
            Console.WriteLine("Camión frenando");
        }

        public override string ToString()
        {
            return $"   Camión\n" + base.ToString() + "\n";
        }
    }
}
