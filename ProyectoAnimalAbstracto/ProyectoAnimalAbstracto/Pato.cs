﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnimalAbstracto
{
    internal class Pato : Ave
    {
        public Pato(string nombre, int edad) : base(nombre, edad)
        {
        }

        public override void Volar()
        {
            Console.WriteLine("Volando...");
        }

        public override void Hablar()
        {
            Console.WriteLine("Cuac cuac!");
        }
    }
}
