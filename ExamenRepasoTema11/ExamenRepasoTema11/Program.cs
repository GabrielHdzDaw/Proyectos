//Autor: Gabriel Hernández Collado
//Fecha: 3/4/2025
//Descripcion: 


namespace ExamenRepasoTema11
{
    internal class Program
    {
        public static void VerificarDirectorio()
        {
            string ruta = ;
            do
            {
                Console.WriteLine("Introduce ruta: ");
                ruta = Console.ReadLine();
            } while (!Directory.Exists(ruta));

            List<FileSystemInfo> fileSystemInfo = new List<FileSystemInfo>();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
