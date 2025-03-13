//Autor: Gabriel Hernández Collado
//Fecha: 13/3/2025
//Descripción: Pide un nombre de un fichero al usuario y saca por pantalla las líneas que comiencen por A o a.
//Número de línea: contenido de línea.
//Hazlo 2 veces una con StreamReader y otra con ReadAllLines (convertir a lista y usar findAll)


namespace ProyectoLineasQueEmpiezanPorA
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");
            string entradaUsuario = Console.ReadLine();
            return entradaUsuario;
        }

        public static void MostrarLineas()
        {
            string rutaFichero = PedirRutaFichero();
            if (File.Exists(rutaFichero))
            {
                try
                {
                    new List<string>(File.ReadAllLines(rutaFichero)).FindAll(l => l.ToUpper().StartsWith('A')).ForEach(l => Console.WriteLine(l));
                }
                catch (IOException)
                {
                    Console.WriteLine("Ha habido un problema al leer el archivo");
                }
                
            }
        }
        public static void Main(string[] args)
        {
           MostrarLineas();
        }
    }
}
