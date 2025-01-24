using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVehiculoAbstracto
{
    internal class Motocicleta:Vehiculo
    {
        public Motocicleta(string marca, string modelo, string color, int potencia, int peso) :base(marca, modelo, color, potencia, peso, 2) 
        {
            
        }

        public override void Frenar()
        {
            Console.WriteLine("Moto Frenando");
        }
        public override void Acelerar()
        {
            Console.WriteLine("Moto Acelerando");
        }

        public override string ToString()
        {
            return $"   Motocicleta\n" + base.ToString() + "\n";
        }
    }
}
