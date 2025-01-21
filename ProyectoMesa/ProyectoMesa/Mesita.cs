using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMesa
{
    internal class Mesita:Mesa
    {
        public Mesita():base(0.5f ,1)
        {
            Console.WriteLine("Creando mesita");
        }
    }
}
