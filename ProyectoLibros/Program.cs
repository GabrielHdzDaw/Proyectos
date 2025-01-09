namespace ProyectoLibros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro.SetAutor("Ronaldinho");
            libro.SetTitulo("Ronaldinho Soccer");
            libro.SetUbicacion("Brazil");

            Console.WriteLine($"Autor: {libro.GetAutor()}");
            Console.WriteLine($"Título: {libro.GetTitulo()}");
            Console.WriteLine($"Ubicación: {libro.GetUbicacion()}");
        }
    }
}
