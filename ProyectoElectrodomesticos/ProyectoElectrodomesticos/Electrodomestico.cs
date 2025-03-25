using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoElectrodomesticos
{
    internal abstract class Electrodomestico
    {
        private string codigo;
        private string nombre;
        private string descripcion;
        private double precioCompra;
        private double precioVenta;
        private char cEnergetica;

        public Electrodomestico(string codigo, string nombre, string descripcion, double precioCompra, double precioVenta, char cEnergetica)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.cEnergetica = cEnergetica;
        }

        protected string Codigo { get => codigo; set => codigo = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Descripcion { get => descripcion; set => descripcion = value; }
        protected double PrecioCompra { get => precioCompra; set => precioCompra = value; }
        protected double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        protected char CEnergetica { get => cEnergetica; set => cEnergetica = value; }

        public override string ToString()
        {
            return $"Código: {codigo}, Nombre: {nombre}, Descripción: {descripcion}, Precio de Compra: {precioCompra}, Precio de Venta: {precioVenta}, Clasificación Energética: {cEnergetica}";
        }

    }
}
