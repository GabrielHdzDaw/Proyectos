//Autor: Gabriel Hernández Collado
//Fecha: 13/3/2025
//Descripción: Crea un programa de C# que pida al usuario el nombre de un fichero y que si existe,
//vuelque el contenido a un fichero  acabado ".out.txt". y cuyas líneas estés al revés del original:

//Hola

//Soy yo

//El fichero de salida será:

//    aloH
//    oy yoS

namespace ProyectoTextoReves2
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");
            string entradaUsuario = Console.ReadLine();
            return entradaUsuario;
        }
        public static void CambiarLineas()
        {
            string rutaFichero = PedirRutaFichero();
            if (File.Exists(rutaFichero))
            {
                try
                {
                    string[] strings = File.ReadAllLines(rutaFichero);
                    List<string> list = new List<string>();
                    foreach (string s in strings)
                    {
                        string reverseString = "";
                        for (int  i = s.Length - 1; i >= 0; i--)
                        {
                            reverseString += s[i];
                        }
                        list.Add(reverseString);
                    }
                    File.WriteAllLines(@"..\..\..\out.txt", list.ToArray());
                }
                catch (IOException)
                {
                    Console.WriteLine("Ha habido un problema al leer el archivo");
                }
            }
            else
            {
                Console.WriteLine("El fichero no existe");
            }
        }
        static void Main(string[] args)
        {
            CambiarLineas();
        }
    }
}
