using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCoches
{
    internal class Moto:Vehiculo
    {
        public Moto(string marca, string modelo, int cilindrada, double potencia) : base(marca, modelo, cilindrada, potencia, 2)
        {
            Console.WriteLine("Constructor moto");

        }

        
    }
}
