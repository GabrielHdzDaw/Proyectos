//Autor: Gabriel Hernández Collado
//Fecha: 18/3/2025
//Descripción: Crea un programa que copie un fichero origen a otro destino. Debes usar un FileStream y un array del tamaño del fichero completo. Debe funcionar así:
//mcopy file e:\file2
//Si el origen no existe simplemente generaramos el destino vacío, y si por el contrario el destino sí existe, lo debemos sobreescribir y avisar de que lo hemos sobreescrito.


namespace mcopy
{
    internal class Program
    {
        public static bool ValidarArgs(string[] args)
        {
            return args.Length == 2;
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

        public static void EscribirBytes(string[] args, byte[] bytes)
        {
            if (File.Exists(args[1]))
            {
                FileStream fs2 = File.OpenWrite(args[1]);
                fs2.Write(bytes, 0, bytes.Length);
                Console.WriteLine("Archivo sobreescrito");
                fs2.Close();
            }
            else
            {
                Console.WriteLine("Creando archivo vacío");
                FileStream fs2 = File.Create(args[1]);
                fs2.Close();
            }
        }

        public static void CopiarFichero(string[] args)
        {
            byte[] bytes = LeerBytes(args);
            EscribirBytes(args, bytes);
        }

        static void Main(string[] args)
        {
            if (ValidarArgs(args))
            {
                CopiarFichero(args);
            }
            else
            {
                Console.WriteLine("Uso: {ruta_archivo_origen} {ruta_destino}");
            }
        }
    }
}
