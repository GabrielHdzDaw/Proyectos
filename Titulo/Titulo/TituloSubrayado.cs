using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppTest
{
    internal class TituloSubrayado: Titulo
    {
        
        public override void Mostrar()
        {
            base.Mostrar();
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(new string('-', texto.Length));
        }
    }
}
