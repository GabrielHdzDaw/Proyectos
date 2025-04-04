//Autor: Gabriel Hernández Collado


using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json;

namespace Examen
{
    internal class Program
    {
        public static string VerificarDirectorio()
        {
            bool existe = false;
            string ruta = "";
            {
                Console.Write("Introduce una ruta: ");
                ruta = Console.ReadLine();
                if (!Directory.Exists(ruta))
                {
                    Console.WriteLine("Ruta no encontrada.");
                }
                else
                {
                    Console.WriteLine("Ruta encontrada.");
                    existe = true;
                }
            }
            while (!Directory.Exists(ruta)) ;
            return ruta;
        }

        public static List<FileSystemInfoData> VerificarFichero()
        {
            List<FileSystemInfoData> lista;
            string ruta = "../../../directoryContents.json";
            if (File.Exists(ruta) && File.ReadAllText(ruta).Length > 0)
            {
                string json = File.ReadAllText(ruta);

                lista = JsonSerializer.Deserialize<List<FileSystemInfoData>>(json);

            }
            else
            {
                lista = new List<FileSystemInfoData>();
            }
            return lista;
        }

        public static List<FileInfo> LeerFicheros(string ruta)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(ruta);
            FileInfo[] ficheros = directoryInfo.GetFiles();
            List<FileInfo> lista = new List<FileInfo>();
            lista.AddRange(ficheros);
            return lista;
        }
        public static List<DirectoryInfo> LeerDirectorios(string ruta)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(ruta);
            DirectoryInfo[] directorios = directoryInfo.GetDirectories();
            List<DirectoryInfo> lista = new List<DirectoryInfo>();
            lista.AddRange(directorios);
            return lista;
        }

        public static void SerializarLista(List<FileSystemInfoData> lista)
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            string jsonString = JsonSerializer.Serialize(lista, opciones);
            File.WriteAllText("../../../directoryContents.json", jsonString);
        }

        //public static void CompararListas(List<FileSystemInfoData> lista1, List<FileSystemInfo> lista2)
        //{
        //    bool iguales = false;
        //    if (lista1.Count() == lista2.Count())
        //    {
        //        for (int i = 0; i < lista1.Count(); i++)
        //        {
        //            if (lista1.ElementAt(i).Longitud == (FileInfo)lista2.)
        //            {
                        
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(lista1.Count() > lista2.Count ? "Hay más archivos." : "Hay menos archivos.");
        //    }



        //}

        public static int SeleccionarOpcion(string[] opciones)
        {
            

            int opcionSeleccionada = 0;
            while (true)
            {
                Console.Clear();
                foreach (string str in opciones)
                {
                    Console.WriteLine(str);
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (opcionSeleccionada > 0)
                            {
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("-> " + opciones[opcionSeleccionada]);
                                opcionSeleccionada--;
                            }
                            else
                            {
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("-> " + opciones[opcionSeleccionada]);

                                opcionSeleccionada = opciones.Length - 1;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (opcionSeleccionada < opciones.Length - 1)
                            {
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("-> " + opciones[opcionSeleccionada]);
                                opcionSeleccionada++;
                            }
                            else
                            {
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("-> " + opciones[opcionSeleccionada]);
                                opcionSeleccionada = 0;
                            }
                            break;
                        case ConsoleKey.Enter:
                            return opcionSeleccionada;
                        default:
                            break;
                    }
                }
            }
        }
        public static string[] opcionesMenu =
        {
            "Abrir un archivo",
            "Mostrar todos los ficheros ordenados por fecha de modificación",
            "Filtrar por nombre",
            "Contar los ficheros",
            "Buscar archivos modificados en el último mes",
            "Muestra los directorios",
            "Contar archivos con longitud mayor a: ",
            "Salir y guardar"
        };
        public static void SwitchMenu()
        {
            string ruta = VerificarDirectorio();
            List<FileInfo> listaFicheros = LeerFicheros(ruta);
            List<DirectoryInfo> listaDirectorios = LeerDirectorios(ruta);
            List<FileSystemInfo> lista = new List<FileSystemInfo>();
            lista.AddRange(listaFicheros);
            lista.AddRange(listaDirectorios);

            int opcionSeleccionada = -1;
            do
            {
                opcionSeleccionada = SeleccionarOpcion(opcionesMenu);
                switch (opcionSeleccionada)
                {   
                    case 0:
                        string[] opciones = new string[listaFicheros.Count() - 1];
                        for (int i = 0;  i < opciones.Length; i++)
                        {
                            opciones[i] = listaFicheros.ToArray()[i].ToString();
                        }
                        int opcion = SeleccionarOpcion(opciones);
                        Process proc = Process.Start("notepad.exe", opciones[opcion]);

                        break;
                    case 1:
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        listaFicheros.ForEach(f => Console.WriteLine(f));
                        Console.WriteLine(listaFicheros.Count() + " ficheros");
                        break;
                    case 4:
                        listaFicheros.Where(f => f.LastWriteTime.Month == DateTime.Now.Month).ToList().ForEach(f => Console.WriteLine(f));
                        break;
                    case 5:
                        listaDirectorios.ForEach(f => Console.WriteLine(f));
                        Console.WriteLine(listaDirectorios.Count() + " ficheros");
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        break;
                }
            }
            while (opcionSeleccionada != 7);
        }
        static void Main(string[] args)
        {
            SwitchMenu();
        }
    }
}
