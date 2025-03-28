//Autor: Gabriel Hernández Collado
//Fecha: 28/3/2025
//Descripción: Crea un programa llamado directorio que recibirá como parámetro en la línea de comandos :
//     --directorio crear nombreDirectorio  --> (CreateDirectory)
//     --directorio mover nombreDirectorioOrigen nombreDirectorioDestino --> (Move)
//     --directorio borrar nombreDirectorio    --> (Delete)
//     --directorio explorar nombreDirectorio --> (GetFiles)

//En todos los casos debéis comprobar primero si existe el directorio. Y después realizar la operación adecuada. 
//    Para cada operación se deben capturar las excepciones adecuadas.


namespace ProyectoDirectorio
{
    internal class Program
    {
        
        public static void SwitchMenu(string[] args)
        {
            string opcion = args[0];
            string nombreDirectorio = args[1];
            string nombreDirectorioDestino = "";
            if (args.Length == 3)
            {
                nombreDirectorioDestino = args[2];
            }

            switch(opcion)
            {
                case "crear":
                    Directory.CreateDirectory(nombreDirectorio);
                    break;
                case "mover":
                    Directory.Move(nombreDirectorio, nombreDirectorioDestino);
                    break;
                case "borrar":
                    Directory.Delete(nombreDirectorio);
                    break;
                case "explorar":
                    foreach (string directorio in Directory.GetFiles(nombreDirectorio))
                    {
                        Console.WriteLine(directorio);
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                SwitchMenu(args);
            }
            else
            {
                Console.WriteLine("Uso: directorio [crear|mover|borrar|explorar] [nombreDirectorio] [nombreDirectorioDestino]");
            }
        }
    }
}
