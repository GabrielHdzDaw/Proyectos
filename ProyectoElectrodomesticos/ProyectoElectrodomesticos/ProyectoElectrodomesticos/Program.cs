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
            Console.WriteLine("0. Salir");
            Console.WriteLine();
            Console.Write("Introduce una opción: ");
        }

        public static void SwitchMenu(Inventario inventario)
        {
            int entradaUsuario;
            do
            {
                MostrarMenu();
                entradaUsuario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (entradaUsuario)
                {
                    case 1:
                        Console.WriteLine("Crear un nuevo electrodoméstico");
                        inventario.CrearElectrodomestico(inventario);
                        break;
                    case 2:
                        Console.WriteLine("Borrar un electrodoméstico");
                        inventario.BorrarUnElectrodomestico();
                        break;
                    case 3:
                        Console.WriteLine("Modificar un electrodoméstico");
                        break;
                    case 4:
                        Console.WriteLine("Mostrar todos los electrodomésticos de una gama ordenados por nombre");
                        Console.Write("Introduce la gama: ");
                        string gama = Console.ReadLine();
                        switch (gama)
                        {
                            case "blanca":
                                inventario.GetElectrodomesticos().FindAll(e => e.GetType() == typeof(Blanca)).OrderBy(e => e.Nombre).ToList().ForEach(e => Console.WriteLine(e));
                                break;
                            case "gris":
                                inventario.GetElectrodomesticos().FindAll(e => e.GetType() == typeof(Gris)).OrderBy(e => e.Nombre).ToList().ForEach(e => Console.WriteLine(e));
                                break;
                            case "marron":
                                inventario.GetElectrodomesticos().FindAll(e => e.GetType() == typeof(Marron)).OrderBy(e => e.Nombre).ToList().ForEach(e => Console.WriteLine(e));
                                break;
                            case "pae":
                                inventario.GetElectrodomesticos().FindAll(e => e.GetType() == typeof(Pae)).OrderBy(e => e.Nombre).ToList().ForEach(e => Console.WriteLine(e));
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Mostrar todos los electrodomésticos con precio de venta inferior a… ordenados por precio de venta");
                        Console.Write("Introduce el precio: ");
                        double precio = Convert.ToDouble(Console.ReadLine());
                        inventario.GetElectrodomesticos().Where(e => e.PrecioVenta < precio).OrderBy(e => e.PrecioVenta).ToList().ForEach(e => Console.WriteLine(e));
                        
                        break;
                    case 6:
                        Console.WriteLine("Mostrar todos los electrodomésticos con precio de coste inferior a… ordenados por nombre y por precio de coste.");
                        Console.Write("Introduce el precio: ");
                        double precio2 = Convert.ToDouble(Console.ReadLine());
                        inventario.GetElectrodomesticos().Where(e => e.PrecioCompra < precio2).
                            OrderBy(e => e.Nombre).ThenBy(e => e.PrecioCompra).
                            ToList().ForEach(e => Console.WriteLine(e));
                        break;
                    case 7:
                        Console.WriteLine("Recalcular el precio de venta de los electrodomésticos cuya descripción contenga un texto.");
                        Console.Write("Introduce el texto a buscar: ");
                        string texto = Console.ReadLine();
                        inventario.GetElectrodomesticos().Where(e => e.Descripcion.Contains("texto")).ToList().ForEach(e => e.PrecioVenta = e.PrecioVenta * 1.1);
                        break;
                    case 8:
                        Console.WriteLine("Añadir una cantidad a un electrodoméstico");
                        Console.Write("Introduce el código del electrodoméstico: ");
                        string codigo = Console.ReadLine();
                        Console.Write("Introduce la cantidad a añadir: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        inventario.GetElectrodomesticos().Find(e => e.Codigo == codigo).Cantidad += cantidad;
                        break;
                    case 9:
                        Console.WriteLine("Añadir una cantidad a los electrodomésticos con texto en su nombre o descripción");
                        Console.Write("Introduce el texto a buscar: ");
                        string texto2 = Console.ReadLine();
                        Console.Write("Introduce la cantidad a añadir: ");
                        int cantidad2 = Convert.ToInt32(Console.ReadLine());
                        inventario.GetElectrodomesticos().Where(e => e.Descripcion.Contains(texto2) || e.Nombre.Contains(texto2)).
                            ToList().ForEach(e => e.Cantidad += cantidad2);
                        break;
                    case 10:
                        Console.WriteLine("Mostrar el inventario");
                        inventario.MostrarElectrodomesticos();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.WriteLine();
            } while (entradaUsuario != 0);
        }
        public static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            inventario.LeerFichero("blanca");
            inventario.LeerFichero("gris");
            inventario.LeerFichero("marron");
            inventario.LeerFichero("pae");

            SwitchMenu(inventario);
        }
    }
}
