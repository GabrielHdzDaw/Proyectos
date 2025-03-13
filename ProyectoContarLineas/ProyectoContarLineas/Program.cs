//Autor: Gabriel Hernández Collado
//Fecha: 13/3/2025
//Descripción: Crea un programa que pida el nombre de un fichero al usuario, comprueba si existe y muestre a continuación cuantas líneas tiene dicho fichero


namespace ProyectoContarLineas
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");
            string entradaUsuario = Console.ReadLine();
            return entradaUsuario;
        }

        public static string ContarLineas()
        {
            string fichero = PedirRutaFichero();
            int numeroLineas = 0;
            string res = "";
            if (File.Exists(fichero))
            {
                try
                {
                    string[] lineas = File.ReadAllLines(fichero);
                    numeroLineas = lineas.Length;
                    res = numeroLineas > 0 ? $"El fichero tiene {numeroLineas} líneas." : "El fichero está vacío";
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
            Console.WriteLine(ContarLineas());
        }
    }
}
