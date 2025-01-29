/* Autor: gabhercol
/* Fecha: 1/28/2025 12:05:10 PM
/* Descripción: Vamos a añadir a la clase Dispositivo el interfaz IComparable para poder ordenar por nombre alfabéticamente.
Además en el Main ordenaremos también por tamaño de la pantalla descendente.
*/
namespace ProyectoDispositivosIComparableIComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de dispositivos a introducir: ");
            int numDispositivos = Convert.ToInt32(Console.ReadLine());
            string inputUsuario;

            Dispositivo[] dispositivos = new Dispositivo[numDispositivos];

            for (int i = 0; i < dispositivos.Length; i++)
            {
                string nombre;
                do
                {
                    Console.Write("Introduce nombre del dispositivo: ");
                    nombre = Console.ReadLine();
                }
                while (nombre != "ordenador" && nombre != "tablet" && nombre != "smartphone");

                Console.Write("Introduce velocidad de proceso: ");
                int velocidad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce tamaño de pantalla: ");
                double tamanoPantalla  = Convert.ToDouble(Console.ReadLine());

                switch (nombre.ToLower().Trim())
                {
                    case "ordenador":
                        dispositivos[i] = new Ordenador(nombre, velocidad, tamanoPantalla);
                        break;
                    case "tablet":
                        dispositivos[i] = new Tablet(nombre, velocidad, tamanoPantalla);
                        break;
                    case "smartphone":
                        dispositivos[i] = new Smartphone(nombre, velocidad, tamanoPantalla);
                        break;
                    default:
                        Console.WriteLine("Nombre de dispositivo no válido. Introduce \"ordenador\", \"smartphone\" o \"tablet\"");
                        break;
                }
            }

            Array.Sort(dispositivos, (d1, d2) => d2.GetTamanoPantalla().CompareTo(d1.GetTamanoPantalla()));

            foreach (Dispositivo dispositivo in dispositivos)
            {
                Console.WriteLine(dispositivo);
                dispositivo.Conectar();
            }
        }
    }
}
