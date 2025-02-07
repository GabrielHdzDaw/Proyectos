using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCampoSolar
{
    internal class Motor:Elemento
    {
        
        int grados;

        public Motor(string nombre, int grados):base(nombre)
        {
            this.grados = grados;
        }

        public void Girar(int grados)
        {
            this.grados = grados;
        }

        public override string ToString()
        {
            return base.ToString() + " " + grados + "º";
        }

    }
}
