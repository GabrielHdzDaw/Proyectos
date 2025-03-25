//Autor: Gabriel Hernández Collado
//Fecha: 25/3/2025
//Descripción: 


namespace ProyectoElectrodomesticos
{
    internal class Program
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("1. Crear un nuevo electrodoméstico");
            Console.WriteLine("2. Borrar un electrodoméstico");
            Console.WriteLine("3. Modificar un electrodoméstico");
            Console.WriteLine("4. Mostrar todos los electrodomésticos de una gama ordenados por nombre");
            Console.WriteLine("5. Mostrar todos los electrodomésticos con precio de venta inferior a… ordenados por precio de venta");
            Console.WriteLine("6. Mostrar todos los electrodomésticos con precio de coste inferior a… ordenados por nombre y por precio de coste.");
            Console.WriteLine("7. Recalcular el precio de venta de los electrodomésticos cuya descripción contenga un texto.");
            Console.WriteLine("8. Añadir una cantidad a un electrodoméstico");
            Console.WriteLine("9. Añadir una cantidad a los electrodomésticos con texto en su nombre o descripción.");
            Console.WriteLine("10. Mostrar el inventario");
        }
        public static void SwitchMenu()
        {

        }
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            inventario.LeerFichero("blanca");
            inventario.LeerFichero("gris");
            inventario.LeerFichero("marron");
            inventario.LeerFichero("pae");

            foreach (Electrodomestico e in inventario.GetElectrodomesticos())
            {
                Console.WriteLine(e);
            }
        }
    }
}
