using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoElectrodomesticos
{
    internal class Blanca : Electrodomestico
    {
        public Blanca(string codigo, string nombre, string descripcion, double precioCompra, double precioVenta, string cEnergetica, int cantidad) : base(codigo, nombre, descripcion, precioCompra, precioVenta, cEnergetica, cantidad)
        {
        }
    }
}
