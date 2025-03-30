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
        public static FileSystemInfo[] ObtenerFicheros(string ruta)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(ruta);
            FileInfo[] archivos = directoryInfo.GetFiles();
            DirectoryInfo[] directorios = directoryInfo.GetDirectories();

            FileSystemInfo[] contenido = new FileSystemInfo[archivos.Length + directorios.Length];

            for (int i = 0; i < directorios.Length; i++)
            {
                contenido[i] = directorios[i];
            }

            for (int i = 0; i < archivos.Length; i++)
            {
                contenido[directorios.Length + i] = archivos[i];
            }

            return contenido;
        }

        public static void MostrarFicheros(string[] ficheros, int seleccionado)
        {
            for (int i = 0; i < ficheros.Length; i++)
            {

                if (i == seleccionado)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("> " + ficheros[i]);
                }
                else
                {
                    Console.WriteLine(ficheros[i]);
                }

                Console.ResetColor();
            }
        }

        public static FileInfo[] ObtenerFicherosDirectorioPadre()
        {
            DirectoryInfo parentDir = new DirectoryInfo(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
            return parentDir.GetFiles();
        }

        public static int Select(string[] options)
        {
            FileInfo[] otherOptions;
            bool escape = false;
            Console.CursorVisible = false;
            int selectedOption = 0;
            while (true)
            {
                Console.Clear();
                MostrarFicheros(options, selectedOption);
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedOption > 0)
                        {
                            selectedOption--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (selectedOption < options.Length - 1)
                        {
                            selectedOption++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        return selectedOption;
                        
                    case ConsoleKey.Escape:
                        return 0;
                        
                    default:
                        break;
                }
            }
        }

        public static void SwitchSelect(int opcion)
        {
            switch (opcion)
            {
                case 0:
                    break;
                case 1:
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            FileInfo[] ficheros = ObtenerFicheros();
            string[] nombresFicheros = new string[ficheros.Length + 1];
            nombresFicheros[0] = "..\\";
            for (int i = 1; i < ficheros.Length; i++)
            {
                nombresFicheros[i] = ficheros[i].Name;
            }
            
            int seleccionado = Select(nombresFicheros);
            Console.WriteLine("Has seleccionado: " + nombresFicheros[seleccionado]);
        }
    }
}
