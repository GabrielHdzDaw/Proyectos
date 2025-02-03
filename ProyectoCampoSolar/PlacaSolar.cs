using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCampoSolar
{
    internal class PlacaSolar:Elemento
    {
        string nombre;
        bool encendido = false;
        int grados;

        public PlacaSolar(string nombre, int grados):base(nombre)
        {
            this.nombre = nombre;
            this.grados = grados;
        }

        public int GetGrados()
        {
            return grados;
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
