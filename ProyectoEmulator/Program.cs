/* Autor: gabri
/* Fecha: 01/02/2025 21:03:40
/* Descripción: Se desea crear un emulador de múltiples ordenadores clásicos usando un diseño orientado a objetos.

Para ello, en primer lugar se considerará, de forma simplificada, que un Ordenador está formado únicamente
por un Procesador y una Memoria. También nos interesará almacenar un nombre para cada ordenador. Los tres 
valores, en ese orden, se deberán indicar en el (único) constructor de la clase Ordenador. Sólo se creará 
un método Get para poder acceder a su nombre nombre, pero también se incluirá un método ToString, que devolverá
algo como "ZxSpectrum, procesador Z80, 8 bits, 3.5 MHz, 16384 bytes de memoria".

Un Procesador contendrá una serie de posiciones internas de memoria, llamadas registros (por ejemplo A o AX).
Por ello, queremos que esta clase contenga un único constructor, que recibirá tres parámetros: el primero será
el número de bits del procesador (por ejemplo, 8); el segundo será la velocidad de proceso, medida en Megahertzios
(por ejemplo, 3.58) y el tercero será una cadena de texto que indicará los nombres de los registros separados por 
espacios (por ejemplo "A B C D"). Además, existirá un método AnadirOrden, que servirá para anotar órdenes que acepta
este procesador. Estas órdenes se indicarán como dos parámetros de AnadirOrden. El primer parámetro indicará el código
de esa orden (por ejemplo 121 en base decimal o 0x79 en base hexadecimal) y el segundo parámetro será el equivalente
en ensamblador de esa orden (por ejemplo, "LD A, C"). Más adelante, todas las órdenes se almacenarán en una estructura
de datos, como un array, pero esta primera versión no debe preocuparse aún de eso, sino que en ella, el método 
AnadirOrden estará vacío. También existirá un método MostrarOrdenes, que, en una versión posterior, mostraría
toda la lista de órdenes que soporta el procesador, pero que por ahora sólo mostrará "Lista de órdenes aún no
disponible". Igualmente, la clase Procesador tendrá métodos Get para su número de bits y para su velocidad de
proceso. También tendrá un método "ToString", que devolverá algo como "8 bits, 3.5 MHz".

La clase Memoria contendrá un dos atributos: el tamaño y un array de bytes que contendrá la información real.
Existirá un constructor que recibirá como parámetro el tamaño de la memoria, en bytes (por ejemplo, 65536) y 
creará un array de bytes de ese tamaño. También se creará un segundo constructor, que recibirá el tamaño de la
memoria (por ejemplo, 65536) y el tamaño del bus de datos, medido en bits (por ejemplo, 8). Aun así, este 
constructor todavía no se va a implementar, así que delegará en el primer constructor e ignorará el dato del
tamaño del bus de datos (pero contendrá

un comentario TO DO en su interior, para recordar que se pretende implementar más adelante).
La clase también tendrá métodos Get(dirección) para obtener el valor almacenado en una cierta 
posición de memoria y Set(dirección, valor) para guardar un cierto valor en una posición de memoria. 
También tendrá un método GetTamano, que devuelva su tamaño, medido en bytes.

Crea una clase ProcesadorZ80, que permita crear un procesador Zilog Z80 o derivado. Esta clase
contendrá un único constructor para indicar la velocidad en MHz (porque el número de bits quedará 
prefijado a 8 y los registros estarán prefijados a "A B C D E F H L"). Su MostrarOrdenes escribirá 
en pantalla el texto "Z80: " seguido del aviso que se ha indicado en la clase procesador. Su método
ToString devolverá "Z80, " seguido del ToString de un procesador genérico.

Crea una clase Procesador6502, que permita crear un procesador MOS 6502 o derivado.
Esta clase contendrá un único constructor para indicar la velocidad en MHz (porque el
número de bits quedará prefijado a 8 y los registros a "A X Y"). Su MostrarOrdenes escribirá 
en pantalla el texto "6502: " seguido del aviso previsto en la clase procesador. Su método 
ToString devolverá "6502, " seguido del ToString de un procesador genérico.

Crea un programa de prueba (clase Emuladores) que tenga un array de 4 ordenadores. 
Los dos primeros ordenadores estarán prefijados: un ZxSpectrum, con procesador Z80 a 
3.5 MHz y 16384 bytes de memoria, y un Commodore VIC-20, con procesador 6502 a 1.1 MHz
y 5120 bytes de memoria. A continuación, al usuariose le pedirán los datos de otros 2 
ordenadores más a introducir y luego se mostrarán lo 4 ordenadores almacenados.
*/
namespace ProyectoEmulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordenador[] ordenadores = new Ordenador[4];
            ordenadores[0] = new Ordenador("ZxSpectrum", new ProcesadorZ80(3.5), new Memoria(16384));
            ordenadores[1] = new Ordenador("Commodore VIC-20", new Procesador6502(1.1), new Memoria(5120));

            for (int i = 2; i < ordenadores.Length; i++)
            {
                Console.Write("Introduce nombre del ordenador: ");
                string nombre = Console.ReadLine();
                Console.Write("Introduce velocidad del procesador en MHz: ");
                double velocidad = Convert.ToDouble(Console.ReadLine());
                Console.Write("Introduce tamaño de la memoria en bytes: ");
                int tamano = Convert.ToInt32(Console.ReadLine());
                ordenadores[i] = new Ordenador(nombre, new ProcesadorZ80(velocidad), new Memoria(tamano));
            }

            foreach (Ordenador ordenador in ordenadores)
            {
                Console.WriteLine(ordenador);
            }

        }
    }
}
