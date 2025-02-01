using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmulator
{
    internal class Memoria
    {
        int tamano;
        byte[] datos;
        int bus;

        public Memoria(int tamano)
        {
            this.tamano = tamano;
            datos = new byte[tamano];
        }

        public Memoria(int tamano, int bus)
        {
            this.tamano = tamano;
            datos = new byte[tamano];
            // TO DO
        }

        public byte Get(int direccion)
        {
            return datos[direccion];
        }

        public void Set(int direccion, byte valor)
        {
            datos[direccion] = valor;
        }

        public int GetTamano()
        {
            return tamano;
        }

        public override string ToString()
        {
            return $"{tamano} bytes de memoria";
        }
    }
}
