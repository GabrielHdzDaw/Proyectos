using System;

namespace Fracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraccion f1 = new Fraccion(2, 3);
            Fraccion f2 = new Fraccion(4, 6);

            Console.WriteLine(f1 + f2);
            Console.WriteLine(f1 - f2);
            Console.WriteLine(f1 * f2);
            Console.WriteLine(f1 / f2);
        }
    }
}
