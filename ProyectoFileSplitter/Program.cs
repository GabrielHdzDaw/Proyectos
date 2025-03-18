/* Autor: gabri
/* Fecha: 18/03/2025 20:00:55
/* Descripción: Crea un programa que trocee un fichero en trozos de un determinado tamaño. Debe recibir 
como parámetros el nombre del fichero y el tamaño. Por ejemplo:

split fichero.exe 2000

Si fichero.exe tiene 4500 bytes, este comando creará un fichero llamado fichero.exe.001 de 2000 bytes, 
otro llamado fichero.exe.002 con 2000 bytes y un tercero llamado fichero.exe.003 con 500 bytes.
*/
namespace ProyectoFileSplitter
{
    internal class Program
    {
        public static bool ValidarArgs(string[] args)
        {
            return args.Length == 2;
        }

        public static byte[] LeerBytes(string fichero)
        {
            FileStream fs;
            try
            {
                if (File.Exists(fichero))
                {
                    fs = File.OpenRead(fichero);
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

        public static void FileSplit(string fichero, int tamanyo)
        {
            byte[] bytes = LeerBytes(fichero);
            FileStream fsFichero = new FileStream(fichero, FileMode.Open);
            long nBytes = fsFichero.Length;
            long nFicheros = nBytes / tamanyo;
            long  resto = nBytes % tamanyo;
            int i = 0;
            for (i = 0; i < nFicheros; i++)
            {
                string nombreFichero = fichero + "." + (i + 1).ToString("000");
                FileStream fs = File.Create(nombreFichero);
                fs.Write(bytes, i * tamanyo, tamanyo);
                fs.Close();
                Console.WriteLine($"Creado archivo nº {i + 1}");
            }
        }
        static void Main(string[] args)
        {
            if (ValidarArgs(args))
            {
                string fichero = args[0];
                int tamanyo = int.Parse(args[1]);
                FileSplit(fichero, tamanyo);
            }
            else
            {
                Console.WriteLine("Uso: {fichero} {tamaño_fragmentos}");
            }
        }

    }
}
