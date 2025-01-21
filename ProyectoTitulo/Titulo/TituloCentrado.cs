using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppTest
{
    internal class TituloCentrado:Titulo
    {
        public override void Mostrar()
        {
            x = Console.WindowWidth / 2;
            base.Mostrar();
        }
    }
}
