﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDispositivos
{
    internal class Smartphone : Tactil
    {
        public Smartphone(string nombre, int velocidadProceso, double tamanoPantalla) : base(nombre, velocidadProceso, tamanoPantalla)
        {
        }
        public override void Conectar()
        {
            Console.WriteLine("Smartphone conectado");
        }
    }
}
