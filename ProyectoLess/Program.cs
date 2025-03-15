//Autor: Gabriel Hernández Collado
//Fecha 14/3/2025
//Descripción: Crea un programa que se comporte como el comando Unix "less": debe mostrar el contenido de un fichero
//por pantalla y permitir al usuario moverse hacia arriba y hacia abajo usando las fechas.
//En esta aproximación sencilla, las líneas se mostrarán truncadas a 79 caracteres y se mostrarán sólo 24 líneas.
//El nombre del fichero se recogerá en la línea de comandos, si el fichero no se indica, el programa deberá pedirlo.
//Otras posibles mejoras: permirir PageUp, PageDown, Esc; Mostrar un pie de página como "Líneas 1-24/390".

using System.Collections.Generic;

namespace ProyectoMore
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");
            return Console.ReadLine();
        }

        public static void MostrarLineas(int principio, int final, List<string> lista, int totalLineas)
        {
            for (int i = principio; i <= final && i < totalLineas; i++)
            {
                string linea = lista[i];


                if (linea.Length > 79)
                {
                    Console.WriteLine($"{i + 1} {linea.Substring(0, 79)}-");
                    string resto = linea.Substring(79);

                    if (resto.Length > 0)
                    {
                        i += 1;
                        Console.WriteLine($"{i + 1} {resto}");
                    }
                }
                else
                {
                    Console.WriteLine($"{i + 1} {linea}");
                }
            }
        }
        public static void Mostrar(string fichero)
        {
            try
            {
                List<string> list = new List<string>(File.ReadAllLines(fichero));
                int principio = 0;
                int totalLineas = list.Count;
                ConsoleKeyInfo key;

                do
                {
                    Console.Clear();
                    MostrarLineas(principio, principio + 23, list, totalLineas);

                    Console.WriteLine("\nUsa las flechas ↑ ↓ para navegar. Presiona Esc para salir.");

                    key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (principio + 24 < totalLineas)
                            {
                                principio += 24;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (principio - 24 >= 0)
                            {
                                principio -= 24;
                            }
                            break;
                    }
                } while (key.Key != ConsoleKey.Escape);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se ha encontrado el fichero");
            }
            catch (IOException)
            {
                Console.WriteLine("Ha habido un problema al leer el fichero");
            }
            
        }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                string fichero = PedirRutaFichero();
                Mostrar(fichero);
            }
            else if (args.Length == 1)
            {
                string fichero = args[0];
                Mostrar(fichero);
            }
        }
    }
}
