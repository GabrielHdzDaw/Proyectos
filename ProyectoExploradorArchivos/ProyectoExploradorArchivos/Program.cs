//Autor: Gabriel Hernández Collado
//Fecha: 28/3/2025
//Descripción: Crea un programa que permita "pasear" por la carpeta actual, al estilo del antiguo
//"Comandante Norton": mostrará la lista de ficheros y subdirectorios de la carpeta actual, y
//permitirá al usuario moverse hacia arriba o abajo dentro de la lista usando las flechas del cursor.
//El elemento seleccionado se mostrará en color distinto del resto


namespace ProyectoExploradorArchivos
{
    internal class Program
    {
        public static FileInfo[] ObtenerFicheros()
        {
            DirectoryInfo DirectoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            return DirectoryInfo.GetFiles();
        }

        public static void MostrarFicheros(string[] ficheros, int seleccionado)
        {
            for (int i = 0; i < ficheros.Length; i++)
            {
                if (i == seleccionado)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(ficheros[i]);
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
