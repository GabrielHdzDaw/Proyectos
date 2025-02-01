using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmulator
{
    internal class Ordenador
    {
        string nombre;
        Procesador procesador;
        Memoria memoria;

        public Ordenador(string nombre, Procesador procesador, Memoria memoria)
        {
            this.nombre = nombre;
            this.procesador = procesador;
            this.memoria = memoria;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public override string ToString()
        {
            return $"{nombre}, procesador {procesador}, {memoria}";
        }
    }
}
