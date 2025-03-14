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
                foreach (string line in list)
                {
                    if (line.Length > 79)
                    {
                        
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
                
            }
            else if (args.Length == 1)
            {
                string fichero = args[0];
                
            }
        }
    }
}
