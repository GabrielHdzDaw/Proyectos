namespace ProyectoVector2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2D vector1 = new Vector2D(4, 2);
            Vector2D vector2 = new Vector2D(8, 6);

            vector1.Sum(vector2);
            Console.WriteLine(vector1);
            Console.WriteLine(vector2);
            Console.WriteLine(vector1 + vector2);
        }
    }
}
