//Autor: Gabriel Hernández Collado
//Fecha: 13/3/2025
//Descripción:Crea un programa que pida al usuario un nombre de fichero y una palabra y cuente cuantas veces aparece esa palabra en el fichero.

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoContarPalabra
{
    
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");

            return Console.ReadLine();
        }

        public static string PedirPalabra()
        {
            Console.Write("Introduce la palabra a buscar: ");
            return Console.ReadLine();
        }

        public static int ContarPalabras()
        {
            string fichero = PedirRutaFichero();
            string palabra = PedirPalabra();
            int contador = 0;

            if (File.Exists(fichero))
            {
                try
                {
                    List<string> lista= new List<string>(File.ReadAllLines(fichero));
                    foreach (string linea in lista)
                    {
                        string[] palabras = linea.Split(' ');
                        foreach (string p in palabras)
                        {
                            if (p.ToLower() == palabra.ToLower())
                            {
                                contador++;
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("Ha habido un problema al leer el archivo");
                }
            }
            return contador;
        }

        public static int ContarPalabras2()
        {
            string fichero = PedirRutaFichero();
            string palabra = PedirPalabra();
            int contador = 0;

            if (File.Exists(fichero))
            {
                try
                {
                    List<string> lista = new List<string>(File.ReadAllLines(fichero));
                    foreach (string linea in lista)
                    {
                        contador += new List<string>(linea.Split(' ')).FindAll(p => p.ToLower() == palabra.ToLower()).Count();
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("Ha habido un problema al leer el archivo");
                }
            }
            return contador;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ContarPalabras2());
        }
    }
}
