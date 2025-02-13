using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema7
{
    internal class Muestra:Elemento
    {
        

        public Muestra(string nombre, int x, int y, bool estado ):base(nombre, x ,y , estado)
        {
        }

        public override string ToString()
        {
            return base.ToString();

        }
    }
}
