/* Autor: gabhercol
/* Fecha: 1/27/2025 12:05:10 PM
/* Descripción: 
*/
namespace ProyectoInterfazGeometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFiguraGeometrica[] figuras = {
                new Cuadrado(34.2),
                new Circulo(3.5),
                new Cuadrado(41.7),
                new Circulo(75.3),
            };

            foreach (IFiguraGeometrica figura in figuras)
            {
                Console.WriteLine(figura.CalcularArea());
                Console.WriteLine(figura.CalcularPerimetro()); 
            }
        }
    }
}
