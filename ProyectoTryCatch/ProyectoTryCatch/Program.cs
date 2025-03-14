namespace ProyectoTryCatch
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");

            return Console.ReadLine();
        }

        public static void Mostrar(string fichero)
        {
            try
            {
                StreamReader sr = new StreamReader(fichero);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El fichero no existe");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
