using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCoches
{
    internal class Coche:Vehiculo
    {
        public Coche(string marca, string modelo, int cilindrada, double potencia):base(marca, modelo, cilindrada, potencia, 4)
        {
            Console.WriteLine("Constructor coche");
        }
    }
}
