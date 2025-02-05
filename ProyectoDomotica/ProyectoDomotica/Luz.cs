using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDomotica
{
    internal class Luz : Dispositivo, IEncendible
    {
        bool encendido = false;
        public Luz(string nombre, bool encendido) : base(nombre)
        {
            this.encendido = encendido;
        }
        public void CambiarEstado()
        {
            encendido = !encendido;
        }

        public bool GetEncendido()
        {
            return encendido;
        }

        public override string ToString()
        {
            return base.ToString() + (encendido ? "encendida" : "apagada");
        }
    }
}
