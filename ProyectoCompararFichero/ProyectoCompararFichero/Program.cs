//Autor: Gabriel Hernández Collado
//Fecha: 20/3/2025
//Descripción: 
//Crea un programa para pedir al usuario 2 nombres de ficheros para comparar su contenido. Deberá mostrar "No encontradas diferencias"
//    si ambos ficheros tiene el mismo contenido, o el número de línea y el contenido de esas líneas de los dos ficheros en caso de no ser iguales.
//    El nombre de los ficheros se leerá desde la línea de comandos, y si no se ha introducido por ahí, pedírselos al usuario.

namespace ProyectoCompararFichero
{
    internal class Program
    {
        public static string PedirFichero()
        {
            Console.Write("Introduce nombre fichero:");
            return Console.ReadLine();
        }
        public static string[] LeerFichero(string fichero)
        {
            string[] lineas;
            try
            {
                lineas = File.ReadAllLines(fichero);
                return lineas;
            }
            catch (IOException)
            {
                Console.WriteLine("Error al leer el fichero");
            }
            return null;
        }

        public static void CompararFicheros(string fichero1, string fichero2)
        {
            
            string[] lineas1 = LeerFichero(fichero1);
            
            string[] lineas2 = LeerFichero(fichero2);

            List<string> resultado = new List<string>();

            if (lineas1.Length != lineas2.Length)
            {
                string[] mayor = lineas1.Length > lineas2.Length ? lineas1 : lineas2;
                string[] menor = lineas1.Length < lineas2.Length ? lineas1 : lineas2;
                for (int i = 0; i < menor.Length; i++)
                {
                    Console.WriteLine(menor[i]);
                    Console.WriteLine(mayor[i]);
                    if (menor[i] != mayor[i])
                    {
                        resultado.Add($"Línea {i + 1} {menor[i]} | {mayor[i]}");
                    }
                }


                for (int i = menor.Length - 1; i < mayor.Length; i++)
                {
                    resultado.Add($"Línea {i + 1} {mayor[i]}");
                }

            }
            else
            {
                for (int i = 0; i < lineas1.Length; i++)
                {
                    Console.WriteLine(lineas1[i]);
                    Console.WriteLine(lineas2[i]);
                    if (lineas1[i] != lineas2[i])
                    {
                        resultado.Add($"Línea {i + 1} {lineas1[i]} | {lineas2[i]}");
                    }
                }
            }

            if (resultado.Count == 0)
            {
                Console.WriteLine("No encontradas diferencias");
            }
            else
            {
                try
                {
                    
                    foreach (string line in resultado)
                    {
                        Console.WriteLine(line);
                    }
                    
                    Console.WriteLine("Diferencias encontradas. Fichero creado.");
                }
                catch (IOException)
                {
                    Console.WriteLine("Ha habido un error al escribir el archivo");
                }
            }

        }
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                CompararFicheros(args[0], args[1]);
            }
            else
            {
                string fichero1 = PedirFichero();
                string fichero2 = PedirFichero();
                CompararFicheros(fichero1, fichero2);
            }

        }
    }
}
