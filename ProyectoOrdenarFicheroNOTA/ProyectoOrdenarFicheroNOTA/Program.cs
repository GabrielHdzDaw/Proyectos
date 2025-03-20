//Autor: Gabriel Hernández Collado
//Fecha: 20/3/2025
//Descripción: Crea un programa que ordene  alfabeticamente las líneas de un fichero de texto pasado como parámetro y vuelque en otro el resultado
//Ejemplo:
//ordena miFichero.txto ficheroOrdenado.txt

//Pista: ReadAllLines Array.Sort

namespace ProyectoOrdenarFicheroNOTA
{

    internal class Program
    {
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

        public static void EscribirBytes(string fichero, byte[] bytes)
        {
            FileStream fs;
            try
            {
                fs = new FileStream(fichero, FileMode.OpenOrCreate);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Ha habido un error al escribir el archivo");
            }
        }

        public static void InvertirFichero(string fichero)
        {
            byte[] bytes = LeerBytes(fichero);
            Array.Sort(bytes);
            EscribirBytes("ficheroOrdenado.txt", bytes);
            Console.WriteLine("Fichero ordenado en 'ficheroOrdenado.txt'");
        }
        static void Main(string[] args)
        {
            if(args.Length == 1)
            {
                InvertirFichero(args[0]);
            }
            else
            {
                Console.WriteLine("Uso: {nombreFichero}");
            }
        }
    }
}
