/* Autor: gabhercol
/* Fecha: 1/28/2025 12:05:10 PM
/* Descripción: Queremos crear un programa que permita llevar control de una serie 
de dispositivos electrónicos programables.

En una primera aproximación simplista, distinguiremos entre dispositivos “táctiles” 
y dispositivos “con teclado”. De los primeros, distinguiremos “smartphones” y “tablets”, y de los segundos sólo “ordenadores”.

De cada dispositivo querremos almacenar un nombre, la velocidad de proceso y el tamaño 
de la pantalla (diagonal, en pulgadas). Deberán crearse los getters y setters adecuados,
junto con un constructor que permita dar valores iniciales. También se debe crear un 
“ToString”, que devuelva un texto como “nombre: Smartphone, 256 Mb, 3.2 pulgadas”, según 
el caso. Deberá existir un método Conectar que será abstracto y que mostrará "Smartphone
conectado" o "Tablet conectado" o "Ordenador conectado".

 Además, se debe crear un programa que permita introducir datos de dispositivos de 
cualquiera de los tres tipos (en un único array) y ver todos los datos que se han introducido.
*/
namespace ProyectoDispositivos
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

            foreach (Dispositivo dispositivo in dispositivos)
            {
                Console.WriteLine(dispositivo);
                dispositivo.Conectar();
            }
        }
    }
}
