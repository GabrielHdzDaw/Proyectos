using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDomotica
{
    internal class Aspirador:Dispositivo, IEncendible
    {
        int bateria;
        bool encendido;
        public Aspirador(string nombre, int bateria, bool encendido) : base(nombre)
        {
            this.bateria = bateria;
            this.encendido = encendido;
        }
        public void CambiarEstado()
        {
            encendido = !encendido;
        }

        public int GetBateria()
        {
            return bateria;
        }

        public bool GetEncendido()
        {
            return encendido;
        }

    }
}
