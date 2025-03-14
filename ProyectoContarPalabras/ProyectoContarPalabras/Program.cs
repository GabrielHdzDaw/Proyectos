//Autor: Gabriel Hernández Collado
//Fecha: 13/3/2025
//Descripción: Crea un programa que pida al usuario un nombre de fichero y muestre el número de palabras que contiene.
//Una palabra será cualquier cosa separada por uno o más espacios:
//Por ejemplo : "Hola, esto              es 2 + 3" contiene 6 palabras

//Habrá que contar las palabras de cada línea del fichero e ir acumulandolas para decir el total al final.


namespace ProyectoContarPalabras
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");
            string entradaUsuario = Console.ReadLine();
            return entradaUsuario;
        }

        public static string ContarPalabras()
        {
            string fichero = PedirRutaFichero();
            int numeroPalabras = 0;
            string res = "";
            if (File.Exists(fichero))
            {
                try
                {
                    string[] lineas = File.ReadAllLines(fichero);
                    foreach (string line in lineas)
                    {
                        string[] palabras  = line.Split(' ');
                        for (int i = 0;  i < palabras.Length; i++)
                        {
                            palabras[i] = palabras[i].Trim();
                        }
                        numeroPalabras += palabras.Length;
                    }
                    res = numeroPalabras > 0 ? $"El fichero tiene {numeroPalabras} palabras." : "El fichero está vacío";
                }
                catch (IOException)
                {
                    Console.WriteLine("Ha habido un problema al leer el fichero");
                }

            }
            else
            {
                res = "El fichero no existe";
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ContarPalabras());
        }
    }
}
