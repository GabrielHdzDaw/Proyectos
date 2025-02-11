using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListaCompra
{
    internal class ListaCompra
    {
        Compra[] compras;

        public ListaCompra()
        {
            compras = new Compra[10];
            compras[0] = new Compra(new Producto("Leche", new string[] { "Mercadona", "Carrefour" }), 1, false, new DateTime(2021, 10, 1));
            compras[1] = new Compra(new Producto("Pan", new string[] { "Mercadona", "Carrefour" }), 2, false, new DateTime(2021, 10, 2));
            compras[2] = new Compra(new Producto("Huevos", new string[] { "Mercadona", "Carrefour" }), 3, false, new DateTime(2021, 10, 3));
            compras[3] = new Compra(new Producto("Azucar", new string[] { "Mercadona", "Carrefour" }), 4, false, new DateTime(2021, 10, 4));
            compras[4] = new Compra(new Producto("Sal", new string[] { "Mercadona", "Carrefour" }), 5, false, new DateTime(2021, 10, 5));
            compras[5] = new Compra(new Producto("Pimienta", new string[] { "Mercadona", "Carrefour" }), 6, false, new DateTime(2021, 10, 6));
            compras[6] = new Compra(new Producto("Cafe", new string[] { "Mercadona", "Carrefour" }), 7, false, new DateTime(2021, 10, 7));
            compras[7] = new Compra(new Producto("Te", new string[] { "Mercadona", "Carrefour" }), 8, false, new DateTime(2021, 10, 8));
            compras[8] = new Compra(new Producto("Cerveza", new string[] { "Mercadona", "Carrefour" }), 9, false, new DateTime(2021, 10, 9));
            compras[9] = new Compra(new Producto("Vino", new string[] { "Mercadona", "Carrefour" }), 10, false, new DateTime(2021, 10, 10));
        }

        public Compra[] GetCompras()
        {
            return compras;
        }


        public void SetCompras(Compra[] compras)
        {
            this.compras = compras;
        }


        public void Mostrar()
        {
            foreach (Compra compra in compras)
            {
                Console.WriteLine(compra);
            }
        }

        public void MarcarAdquirido(int i)
        {
            compras[i - 1].SetAdquirido(true);
        }
    }
}
