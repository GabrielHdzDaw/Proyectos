using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListaCompra
{
    internal class Producto
    {
        string nombre;
        string[] establecimientos;

        public Producto(string nombre, string[] establecimientos)
        {
            this.nombre = nombre;
            this.establecimientos = establecimientos;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string[] GetEstablecimientos()
        {
            return establecimientos;
        }

        public void SetEstablecimientos(string[] establecimientos)
        {
            this.establecimientos = establecimientos;
        }

        public override string ToString()
        {
            return $"Producto: {nombre} Establecimientos: {string.Join(", ", establecimientos)}";
        }
    }
}
