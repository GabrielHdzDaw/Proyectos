﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoElectrodomesticos
{
    internal class Gris : Electrodomestico
    {
        public Gris(string codigo, string nombre, string descripcion, double precioCompra, double precioVenta, char cEnergetica) : base(codigo, nombre, descripcion, precioCompra, precioVenta, cEnergetica)
        {
        }
    }
}
