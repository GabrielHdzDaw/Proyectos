//Autor: Gabriel Hernández Collado
//Fecha: 24/03/2025
//Descripción: Crea un programa llamado Ejercicio_11_02 que sea una nueva versión del anterior, pero serializando la lista de videojuegos a un archivo videojuegos.json


using ProyectoSerializacionXML;

namespace ProyectoSerializacionJSON
{
    internal class Program
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("1. Añadir videojuego");
            Console.WriteLine("2. Mostra videojuegos");
            Console.WriteLine("3. Salir");
            Console.Write("Escoge una opción: ");
        }

        public static void MostrarMenuVideojuego()
        {
            Console.WriteLine("1. Añadir videojuego PC");
            Console.WriteLine("2. Añadir videojuego Consola");
            Console.WriteLine("3. Añadir videojuego normal");
            Console.Write("Escoge una opción: ");
        }

        public static void MostrarVideojuegos(List<Videojuego> juegos)
        {
            foreach (Videojuego j in juegos)
            {
                Console.WriteLine(j);
            }
        }

        public static void AnadirVideojuego(List<Videojuego> lista)
        {
            Console.Write("Introduce título del juego: ");
            string nombreJuego = Console.ReadLine();
            Console.Write("Introduce género del juego: ");
            string generoJuego = Console.ReadLine();
            Console.Write("Introduce precio del juego: ");
            double precioJuego = Convert.ToDouble(Console.ReadLine());

            lista.Add(new Videojuego(nombreJuego, generoJuego, precioJuego));
        }

        public static void AnadirVideojuegoPC(List<Videojuego> lista)
        {
            Console.Write("Introduce título del juego: ");
            string nombreJuego = Console.ReadLine();
            Console.Write("Introduce género del juego: ");
            string generoJuego = Console.ReadLine();
            Console.Write("Introduce precio del juego: ");
            double precioJuego = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce tipo del juego: ");
            string tipoJuego = Console.ReadLine();
            lista.Add(new VideojuegoPC(nombreJuego, generoJuego, precioJuego, tipoJuego));
        }

        public static void AnadirVideojuegoConsola(List<Videojuego> lista)
        {
            Console.Write("Introduce título del juego: ");
            string nombreJuego = Console.ReadLine();
            Console.Write("Introduce género del juego: ");
            string generoJuego = Console.ReadLine();
            Console.Write("Introduce precio del juego: ");
            double precioJuego = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce plataforma del juego: ");
            string plataformaJuego = Console.ReadLine();
            lista.Add(new VideojuegoConsola(nombreJuego, generoJuego, precioJuego, plataformaJuego));
        }


        public static void SwitchMenu(List<Videojuego> lista)
        {
            int entradaUsuario;
            do
            {
                MostrarMenu();
                entradaUsuario = Convert.ToInt32(Console.ReadLine());
                switch (entradaUsuario)
                {
                    case 1:
                        MostrarMenuVideojuego();
                        SwitchMenuTipoJuego(lista);
                        break;
                    case 2:
                        MostrarVideojuegos(lista);
                        break;
                    case 3:
                        Videojuego.GuardarVideojuegos(lista, @"..\..\..\videojuegos.json");
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
            while (entradaUsuario != 3);
        }

        public static void SwitchMenuTipoJuego(List<Videojuego> lista)
        {
            int entradaUsuarioVideojuego = Convert.ToInt32(Console.ReadLine());
            switch (entradaUsuarioVideojuego)
            {
                case 1:
                    AnadirVideojuegoPC(lista);
                    break;
                case 2:
                    AnadirVideojuegoConsola(lista);
                    break;
                case 3:
                    AnadirVideojuego(lista);
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        static void Main(string[] args)
        {
            List<Videojuego> juegos = Videojuego.CargarVideojuegos(@"..\..\..\videojuegos.json");

            SwitchMenu(juegos);
        }
    }
}
