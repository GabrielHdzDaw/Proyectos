using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListaCompra
{
    internal class ProductosDisponibles
    {
        Producto[] productos;
        
        public ProductosDisponibles()
        {
            string[] establecimientos = { "Mercadona", "Carrefour", "Dia" };
            productos = new Producto[10];
            productos[0] = new Producto("Leche", establecimientos);
            productos[1] = new Producto("Pan", establecimientos);
            productos[2] = new Producto("Huevos", establecimientos);
            productos[3] = new Producto("Azucar", establecimientos);
            productos[4] = new Producto("Sal", establecimientos);
            productos[5] = new Producto("Pimienta", establecimientos);
            productos[6] = new Producto("Cafe", establecimientos);
            productos[7] = new Producto("Te", establecimientos);
            productos[8] = new Producto("Cerveza", establecimientos);
            productos[9] = new Producto("Vino", establecimientos);
        }
        

        public Producto[] GetProductos()
        {
            return productos;
        }

        public void SetProductos(Producto[] productos)
        {
            this.productos = productos;
        }

        public override string ToString()
        {
            string productosString = "";
            foreach (Producto producto in productos)
            {
                productosString += producto + "\n";
            }
            return $" Productos: {productosString}";
        }

    }
}
