using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmulator
{
    internal class Procesador
    {
        int bits;
        double velocidad;
        string registros;

        public Procesador(int bits, double velocidad, string registros)
        {
            this.bits = bits;
            this.velocidad = velocidad;
            this.registros = registros;
        }

        public void AnadirOrden(int codigo, string ensamblador)
        {
        }

        public virtual void MostrarOrdenes()
        {
            Console.Write("Lista de órdenes aún no disponible\n");
        }

        public int GetBits()
        {
            return bits;
        }

        public double GetVelocidad()
        {
            return velocidad;
        }

        public override string ToString()
        {
            return $"{bits} bits, {velocidad} MHz";
        }
    }
}
