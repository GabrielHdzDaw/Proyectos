//Autor: Gabriel Hernández Collado
//Fecha: 18/3/2025
//Descripción: Crea un programa que cuente las vocales de un fichero de cualquier tipo. Deberá mostrar por pantalla
//el total de vocales existente en el fichero pasado como parámetro al main. (por consola)
namespace ProyectoContarVocales
{
    internal class Program
    {
        public static bool ValidarArgs(string[] args)
        {
            return args.Length == 1;
        }

        public static byte[] LeerBytes(string[] args)
        {
            FileStream fs;
            try
            {
                if (File.Exists(args[0]))
                {
                    fs = File.OpenRead(args[0]);
                    byte[] bytes = new byte[fs.Length];
                    fs.Read(bytes, 0, bytes.Length);
                    fs.Close();
                    return bytes;
                }

            }
            catch (IOException)
            {
                Console.WriteLine("Ha habido un error al leer el archivo");
            }
            return null;
        }

        public static int ContarVocales(string[] args)
        {
            byte[] bytes = LeerBytes(args);
            int contador = 0;
            foreach (byte b in bytes)
            {
                if("AEIOUaeiou".Contains((char)b))
                {
                    contador++;
                }
            }
            return contador;
        }
        static void Main(string[] args)
        {
            if (ValidarArgs(args))
            {
                Console.WriteLine(ContarVocales(args));
            }
            else
            {
                Console.WriteLine("Uso: {rutaFichero}");
            }
        }
    }
}
