/* Autor: gabhercol
/* Fecha: 1/24/2025 11:33:23 AM
/* Descripción: 
*/
namespace ProyectoVehiculoAbstracto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo[] vehiculos = {
                new Coche("Suzuki", "Escudo", "Rojo", 995, 800, 2),
                new Motocicleta("Kawasaki", "Ninja", "Verde", 300, 206),
                new Camion("MAN", "l129", "Blanco", 700, 5000, 8),
                new Coche("Ford", "GT", "Negro", 710, 1200, 2),
                new Motocicleta("Yamaha", "Ducatti", "Amarillo", 65, 78),
                new Camion("VOLVO", "k876", "Gris", 950, 7800, 12)
            };

            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.Acelerar();
                vehiculo.Frenar();
            }
        }
    }
}
