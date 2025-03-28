using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoElectrodomesticos
{
    internal abstract class Electrodomestico
    {
        protected string codigo;
        protected string nombre;
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;
        protected string cEnergetica;
        protected int cantidad;


        public Electrodomestico(string codigo, string nombre, string descripcion, double precioCompra, double precioVenta, string cEnergetica, int cantidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.cEnergetica = cEnergetica;
            this.cantidad = cantidad;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string CEnergetica { get => cEnergetica; set => cEnergetica = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public override string ToString()
        {
            return $"Código: {codigo}, Nombre: {nombre}, \nDescripción: {descripcion}, \nPrecio de Compra: {precioCompra}, Precio de Venta: {precioVenta}, \nClasificación Energética: {cEnergetica}, Cantidad: {cantidad}";
        }

    }
}
