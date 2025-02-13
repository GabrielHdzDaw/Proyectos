using System.ComponentModel;
using System;

namespace ExamenTema7
{
    internal class Parque
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("1. Mostrar todos los vehículos ordenados por nombre");
            Console.WriteLine("2. Mover todos los vehículos a una parcela adyacente (x+1 o y+1) y extraer muestras con los robots");
            Console.WriteLine("3. Enviar los drones a hacer reconocimiento aéreo");
            Console.WriteLine("4. Revisar y mostrar la carga de todos los vehículos");
            Console.WriteLine("5. Ordenar y mostrar todos los drones según su altitud");
            Console.WriteLine("6. Mostrar todos los rovers inactivos");
            Console.WriteLine("7. Salir del programa");
            Console.Write("Introduce la opción deseada: ");
        }
        public static Parcela[] GenerarParcelas()
        {
            Parcela[] parcelas =
            {
                 new Parcela(0, 0, "Cráter"),
                 new Parcela(1, 0, "Terreno inestable"),
                 new Parcela(2, 0, "Terreno estable"),
                 new Parcela(3, 0, "Cráter"),
                 new Parcela(4, 0, "Terreno inestable"),
                     new Parcela(0, 1, "Terreno estable"),
                 new Parcela(1, 1, "Cráter"),
                 new Parcela(2, 1, "Terreno inestable"),
                 new Parcela(3, 1, "Terreno estable"),
                 new Parcela(4, 1, "Cráter"),
                 new Parcela(0, 2, "Terreno inestable"),
                 new Parcela(1, 2, "Terreno estable"),
                 new Parcela(2, 2, "Cráter"),
                 new Parcela(3, 2, "Terreno inestable"),
                 new Parcela(4, 2, "Terreno estable"),
                 new Parcela(0, 3, "Cráter"),
                 new Parcela(1, 3, "Terreno inestable"),
                 new Parcela(2, 3, "Terreno estable"),
                 new Parcela(3, 3, "Cráter"),
                 new Parcela(4, 3, "Terreno inestable")
                 };
            return parcelas;
        }

        public static Elemento[] GenerarElementos()
        {
            Elemento[] elementos =
            {
                new Rover("Rover1", 0, 0, false, 30, new Camara("Camara1", 0, 0, false, 1, "Sony")),
                new Rover("Rover2", 0, 0, false, 20, new Camara("Camara2", 0, 0, false, 1, "Canon")),
                new Dron("Dron1", 0, 0, 0, false, 60),
                new Dron("Dron2", 0, 0, 0, false, 70),
                new RobotExcavador("RobotExcavador1", 0, 0, false, 50),
                new RobotExcavador("RobotExcavador2", 0, 0, false, 40),
                new EstacionRecarga("EstacionRecarga1", 0, 0, false, false),
                new EstacionRecarga("EstacionRecarga2", 0, 0, false, false),
                new CentroAnalisis("CentroAnalisis1", 0, 0, false)
            };
            return elementos;
        }

        public static Vehiculo[] ObtenerVehiculos(Elemento[] elementos)
        {
            int nVehiculos = 0;

            foreach(Elemento elemento in elementos)
            {
                if(elemento is Vehiculo)
                {
                    nVehiculos++;
                }
            }

            Vehiculo[] vehiculos = new Vehiculo[nVehiculos];
            int i = 0;
            foreach(Elemento elemento in elementos)
            {
                if (elemento is Vehiculo)
                {
                    vehiculos[i] = (Vehiculo)elemento;
                    i++;
                }
            }
            return vehiculos;
        }

        public static void MostrarVehiculosOrdenados(Elemento[] elementos)
        {
            Vehiculo[] vehiculos = ObtenerVehiculos(elementos);
            Array.Sort(vehiculos);
            foreach (Vehiculo vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo);
            }
        }
        static void Main(string[] args)
        {
            Elemento[] elementos = GenerarElementos();
            Parcela[] parcelas = GenerarParcelas();

            int entradaUsuario = -1;
            do
            {
                MostrarMenu();
                entradaUsuario = Convert.ToInt32(Console.ReadLine());
                switch (entradaUsuario)
                {
                    case 1:
                        MostrarVehiculosOrdenados(elementos);
                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                    
                }
            } while (entradaUsuario != 7);
        }
    }
}
