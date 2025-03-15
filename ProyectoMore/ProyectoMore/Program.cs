//Autor: Gabriel Hernández Collado
//Fecha 14/3/2025
//Descripción: Crea un programa que se comporte como el comando "more" de Unix: Debe mostrar el contenido de un fichero y
//pedir al usuario que pulse Enter cada vez que la pantalla esté llena.
//Como una aproximación sencilla, mostraremos las línea truncadas en 79 caracteres, y pararemos después de 24 líneas.
//El nombre del fichero a mostrar debe ser recogido en el línea de comandos. Si no se especifica ahí, el programa lo pedirá.

namespace ProyectoMore
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");
            return Console.ReadLine();
        }

        public static void Mostrar(string fichero)
        {
            try
            {
                List<string> list = new List<string>(File.ReadAllLines(fichero));

                while (list.Count > 0)
                {
                    for (int i = 0; i < 24 && list.Count > 0; i++)
                    {
                        string linea = list[0]; 
                        list.RemoveAt(0); 

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

                    if (list.Count > 0)
                    {
                        Console.WriteLine("Presiona Enter para continuar...");
                        Console.ReadLine();
                    }
                }
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
