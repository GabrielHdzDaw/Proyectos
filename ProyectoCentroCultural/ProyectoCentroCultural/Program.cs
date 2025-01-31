/* Autor: gabhercol
/* Fecha: 1/30/2025 12:39:00 PM
/* Descripción: 
*/
namespace ProyectoCentroCultural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Material[] materiales = {
                new Disco(1, "Disco 1", "Autor 1", "Discografía 1"),
                new Disco(2, "Disco 2", "Autor 2", "Discografía 2"),
                new Libro(3, "Libro 1", "Autor 3", 100),
                new Libro(4, "Libro 2", "Autor 4", 200)
            };

            Peticion[] peticiones1 = {
                new Peticion(materiales[0], "01/01/2025", "01/02/2025"),
                new Peticion(materiales[1], "01/03/2025", "01/04/2025") 
            };

            Peticion[] peticiones2 = {
                new Peticion(materiales[2], "01/05/2025", "01/06/2025"),
                new Peticion(materiales[3], "01/07/2025", "01/08/2025")
            };

            Cliente[] clientes = {
                new Cliente("DNI 1", "Aurelio", peticiones1),
                new Cliente("DNI 2", "Begoña", peticiones2)
            };

            int inputUsuario;

            do
            {
                Console.WriteLine("1. Muestra clientes ordenados por nombre.");
                Console.WriteLine("2. Muestra materiales ordenados por código.");
                Console.WriteLine("3. Salir.");
                Console.Write("Escoge una opción: ");
                inputUsuario = Convert.ToInt32(Console.ReadLine());

                switch (inputUsuario)
                {
                    
                    case 1:
                        Console.WriteLine();
                        Array.Sort(clientes);
                        foreach (Cliente cliente in clientes)
                        {
                            Console.WriteLine(cliente);
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        Array.Sort(materiales);
                        foreach (Material material in materiales)
                        {
                            Console.WriteLine(material);
                        }
                        Console.WriteLine();
                        break;
                }

            } while (inputUsuario != 3);
        }
    }
}
