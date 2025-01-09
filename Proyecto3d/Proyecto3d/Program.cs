using System;

namespace Proyecto3d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto3D[] arrayPuntos = new Punto3D[5];
            for (int i = 0; i < arrayPuntos.Length; i++)
            {
                int p = i + 1;
                Console.Write($"P{p} x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write($"P{p} y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write($"P{p} z: ");
                int z = Convert.ToInt32(Console.ReadLine());

                arrayPuntos[i] = new Punto3D(x, y, z);
            }

            for (int i = 1; i < arrayPuntos.Length; i++)
            {
                Console.WriteLine($"La distancia entre {arrayPuntos[0].ToString()} y {arrayPuntos[i].ToString()} es {arrayPuntos[0].DistanceTo(arrayPuntos[i]).ToString("N2")}");
            }

        }
    }
}
