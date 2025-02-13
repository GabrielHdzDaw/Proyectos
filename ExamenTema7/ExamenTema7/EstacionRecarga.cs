using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema7
{
    internal class EstacionRecarga: Elemento
    {
        bool ocupada = false;
        public EstacionRecarga(string nombre, int x, int y, bool estado, bool ocupada):base(nombre, x, y, estado) 
        { 
            this.ocupada = ocupada;
        }

        public bool GetOcupada()
        {
            return ocupada;
        }

        public void SetOcupada(bool ocupada)
        {
            this.ocupada = ocupada;
        }

    }
}
