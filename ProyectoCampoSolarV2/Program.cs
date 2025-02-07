/* Autor: gabri
/* Fecha: 03/02/2025 14:47:42
/* Descripción: Vamos a crear el panel de control de un campo solar que consta de los siguientes elementos:

Ahora añadiremos un Main donde crearemos un array de elementos (8 elementos distintos) y se mostrará el siguiente menú:
1.- Mostrar todos los elementos ordenados por nombre
2.- Encender todos los elementos encendibles
3.- Apagar todos los elementos encendibles
4.- Girar todos los motores n grados (pedir al usuario número de grados)
5.- Sacar todos los sensores ordenados por grados
6.- Sacar todos elementos apagados
S.- Salir
*/
namespace ProyectoCampoSolar
{
    internal class Program
    {
        public static Sensor[] CrearArraySensores(Elemento[] elementos)
        {
            int numeroSensores = 0;
            foreach (Elemento elemento in elementos)
            {
                if (elemento is Sensor)
                {
                    numeroSensores++;
                }
            }

            Sensor[] sensores = new Sensor[numeroSensores];
            int i = 0;
            foreach (Elemento elemento in elementos)
            {
                if (elemento is Sensor)
                {
                    sensores[i] = (Sensor)elemento;
                    i++;
                }
            }

            return sensores;
        }

        public static void MostrarOpciones()
        {
            Console.WriteLine("1.- Mostrar todos los elementos ordenados por nombre");
            Console.WriteLine("2.- Encender todos los elementos encendibles");
            Console.WriteLine("3.- Apagar todos los elementos encendibles");
            Console.WriteLine("4.- Girar todos los motores n grados");
            Console.WriteLine("5.- Sacar todos los sensores ordenados por grados");
            Console.WriteLine("6.- Sacar todos elementos apagados");
            Console.WriteLine("S.- Salir");
        }

        public static void OrdenarPorNombre(Elemento[] elementos)
        {
            Array.Sort(elementos);
            foreach (Elemento elemento in elementos)
            {
                Console.WriteLine(elemento);
            }
        }

        public static void EncenderEncendibles(Elemento[] elementos)
        {
            foreach (Elemento elemento in elementos)
            {
                if (elemento is IEncendible)
                {
                    ((IEncendible)elemento).Encender();
                }
            }
        }

        public static void ApagarEncendibles(Elemento[] elementos)
        {
            foreach (Elemento elemento in elementos)
            {
                if (elemento is IEncendible)
                {
                    ((IEncendible)elemento).Apagar();
                }
            }
        }

        public static void GirarMotores(Elemento[] elementos)
        {
            Console.WriteLine("Introduce el número de grados");
            int grados = Convert.ToInt32(Console.ReadLine());
            foreach (Elemento elemento in elementos)
            {
                if (elemento is Motor)
                {
                    ((Motor)elemento).Girar(grados);
                }
            }
        }

        public static void MostrarApagados(Elemento[] elementos)
        {
            foreach (Elemento elemento in elementos)
            {
                if (elemento is IEncendible)
                {
                    if (!elemento.GetEncendido())
                    {
                        Console.WriteLine(elemento);
                    }
                }
            }
        }

        public static void MostrarSensoresOrdenados(Sensor[] sensores)
        {
            Array.Sort(sensores, (s1, s2) => s1.GetGrados().CompareTo(s2.GetGrados()));
            foreach (Sensor sensor in sensores)
            {
                Console.WriteLine(sensor);
            }

        }

        public static char SwitchOpciones(char entradaUsuario, Elemento[] elementos, Sensor[] sensores)
        {
            MostrarOpciones();
            entradaUsuario = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            switch (entradaUsuario)
            {
                case '1':
                    OrdenarPorNombre(elementos);
                    break;
                case '2':
                    EncenderEncendibles(elementos);
                    break;
                case '3':
                    ApagarEncendibles(elementos);
                    break;
                case '4':
                    GirarMotores(elementos);
                    break;
                case '5':
                    MostrarSensoresOrdenados(sensores);
                    break;
                case '6':
                    MostrarApagados(elementos);
                    break;
                case 'S':
                    break;
            }
            Console.WriteLine();
            return entradaUsuario;
        }
        static void Main(string[] args)
        {
            Elemento[] elementos = 
            {
                new Sensor("Sensor1", 30),
                new Sensor("Sensor2", 90),
                new Sensor("Sensor3", 70),
                new PlacaSolar("PlacaSolar1", 45),
                new PlacaSolar("PlacaSolar2", 40),
                new PlacaSolar("PlacaSolar3", 40),
                new Motor("Motor1", 90),
                new Motor("Motor2", 80),
                new Motor("Motor3", 70),
                new Distribuidor("Distribuidor1"),
                new Distribuidor("Distribuidor2"),
                new Distribuidor("Distribuidor3"),
                new Bateria("Bateria1"),
                new Bateria("Bateria2"),
                new Bateria("Bateria3")
            };

            Sensor[] sensores = CrearArraySensores(elementos);

            char entradaUsuario = '0';
            do
            {
                entradaUsuario = SwitchOpciones(entradaUsuario, elementos, sensores);

            }
            while (entradaUsuario != 'S');
        }
    }
}
