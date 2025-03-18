//Autor: Gabriel Hernández Collado
//Fecha: 18/3/2025
//Descripción: Crea un programa que pida un nombre de fichero e invierta su contenido y lo vuelque en otro fichero que se llama igual con la extensión .inv (utilizando FileStream y Read)

namespace ProyectoInversorFichero
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");
            string entradaUsuario = Console.ReadLine();
            return entradaUsuario;
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

        public static byte[] InvertirBytes(byte[] bytes)
        {            
            Array.Reverse(bytes);
            return bytes;
        }

        public static void EscribirBytes(byte[] bytes, string fichero)
        {
            if (File.Exists(fichero))
            {
                FileStream fs = File.OpenWrite(fichero);
                fs.Write(bytes, 0, bytes.Length);
                Console.WriteLine("Archivo sobreescrito");
                fs.Close();
            }
            else
            {
                Console.WriteLine("Creando archivo vacío");
                FileStream fs2 = File.OpenWrite(fichero);
                fs2.Close();
            }
        }

        public static void InvertirFichero()
        {
            string fichero = PedirRutaFichero();
            byte[] bytes = InvertirBytes(LeerBytes(fichero));
            EscribirBytes(bytes, fichero);

        }
        static void Main(string[] args)
        {
            InvertirFichero();
        }
    }
}
