﻿/* Autor: gabhercol
/* Fecha: 2/10/2025 11:24:38 AM
/* Descripción: Vamos a desarrollar un sistema de gestión para una flota de vehículos autónomos
utilizando C#. Este sistema deberá permitir la manipulación de distintos tipos de
vehículos, como autos, drones y robots de entrega, a través de un menú interactivo.
También gestionará estaciones de carga para los vehículos.
Todos los elementos tienen un nombre y un estado (activo o inactivo) y pueden
activarse o desactivarse.
Tenemos una serie de estaciones de carga para los vehículos que están en unas
coordenadas fijas y que pueden activarse o desactivarse.
Existen 3 tipos de vehículos:
• Auto: Almacenan la ubicación en la que están y se les puede indicar que se
muevan a unas nuevas coordenadas X, Y, teniendo en cuenta que sólo pueden
moverse a través de carretera.
• Robot de Entrega: También tiene coordenadas y se los puede mover a otras
coordenadas, siempre teniendo en cuenta que estos robots deben ir por aceras
y pasos peatonales. Y se almacena también el % de carga de la batería.
También se podrán enviar a cargar a una estación de carga, se moverá a las
coordenadas de la estación de carga recibida como parámetro y a continuación
se pondrá a cargar. El método cargar consistirá en sumar a la batería un 50%
siempre sin pasarnos de 100%.
• Dron: Tiene coordenadas y se puede mover también, aunque sus coordenadas
incluyen una nueva característica que es la altitud. Se almacena el % de carga
de la batería y también se podrá enviar a cargar a una estación de carga.
Además, contiene una cámara de la que guardamos su nombre, modelo y
resolución. Esta cámara podrá capturar imágenes de por dónde va el dron
cuando se le solicite. (Método capturaImagenes que mostrará un mensaje del
tipo: “Capturando imagen en coordenadas:” X,Y,Altitud)
Todos los vehículos se podrán ordenar por su nombre.
Todos los elementos deberán tener un constructor con todos los datos y otro que sólo
reciba el nombre, poniendo los otros datos en valores por defecto. (Por ejemplo:
inactivo, coordenadas 0,0 etc)
Todos los elementos deberán tener sus getters y sus setters para todos los atributos.
Se creará un ToString en Elemento que tendrá que ser actualizado por todos los
subtipos con sus datos adicionales.
IES SAN VICENTE
EXAMEN TEMA 6
Se creará una clase Flota que tendrá un array con 8 elementos, 2 de cada tipo y en el
Program se mostrará el siguiente menú:
1. Mostrar todos los vehículos ordenados por nombre.
2. Activar todos los elementos desactivados y mostrarlos.
3. Establecer la altura de todos los drones a 3 metros, y mostrarlos.
4. Mover todos elementos cargables a la estación de carga más cercana si el % de
batería es inferior al 20%. (La distancia entre un elemento y una estación de carga
se calculará restando las x y las y). Mostrar resultado
5. Mostrar todos los drones ordenados por altitud.
6. Mostrar todos los elementos inactivos.
7. Capturar imágenes de los drones activos. (Activar el método de capturaImagen de
la cámara de cada dron)
8. Salir del programa.
*/
namespace ProyectoFlota
{
    internal class Program
    {
        public static void MostrarOpciones()
        {
            Console.WriteLine("1. Mostrar todos los vehículos ordenados por nombre.");
            Console.WriteLine("2. Activar todos los elementos desactivados y mostrarlos.");
            Console.WriteLine("3. Establecer la altura de todos los drones a 3 metros, y mostrarlos.");
            Console.WriteLine("4. Mover todos elementos cargables a la estación de carga más cercana si el % de batería es inferior al 20%. (La distancia entre un elemento y una estación de carga se calculará restando las x y las y). Mostrar resultado");
            Console.WriteLine("5. Mostrar todos los drones ordenados por altitud.");
            Console.WriteLine("6. Mostrar todos los elementos inactivos.");
            Console.WriteLine("7. Capturar imágenes de los drones activos. (Activar el método de capturaImagen de la cámara de cada dron)");
            Console.WriteLine("8. Salir del programa.");
            Console.Write("Introduce la opción deseada: ");
        }

        public static Vehiculo[] ObtenerVehiculos(Elemento[] elementos)
        {
            int contador = 0;
            foreach (Elemento elemento in elementos)
            {
                if (elemento is Vehiculo)
                {
                    contador++;
                }
            }
            Vehiculo[] vehiculos = new Vehiculo[contador];
            contador = 0;
            foreach (Elemento elemento in elementos)
            {
                if (elemento is Vehiculo)
                {
                    vehiculos[contador] = (Vehiculo)elemento;
                    contador++;
                }
            }
            return vehiculos;
        }

        public static Dron[] ObtenerDrones(Elemento[] elementos)
        {
            int contador = 0;
            foreach (Elemento elemento in elementos)
            {
                if (elemento is Dron)
                {
                    contador++;
                }
            }
            Dron[] drones = new Dron[contador];
            contador = 0;
            foreach (Elemento elemento in elementos)
            {
                if (elemento is Dron)
                {
                    drones[contador] = (Dron)elemento;
                    contador++;
                }
            }
            return drones;
        }

        public static EstacionCarga[] ObtenerEstaciones(Elemento[] elementos)
        {
            int contador = 0;
            foreach (Elemento elemento in elementos)
            {
                if (elemento is EstacionCarga)
                {
                    contador++;
                }
            }
            EstacionCarga[] estaciones = new EstacionCarga[contador];
            contador = 0;
            foreach (Elemento elemento in elementos)
            {
                if (elemento is EstacionCarga)
                {
                    estaciones[contador] = (EstacionCarga)elemento;
                    contador++;
                }
            }

            return estaciones;
        }

        public static ICargable[] ObtenerCargables(Elemento[] elementos)
        {
            int contador = 0;
            foreach (Elemento elemento in elementos)
            {
                if (elemento is ICargable)
                {
                    contador++;
                }
            }
            ICargable[] cargables = new ICargable[contador];
            contador = 0;
            foreach (Elemento elemento in elementos)
            {
                if (elemento is ICargable)
                {
                    cargables[contador] = (ICargable)elemento;
                    contador++;
                }
            }
            return cargables;
        }

        public static void MostrarVehiculosOrdenados(Elemento[] elementos)
        {
            Vehiculo[] vehiculos = ObtenerVehiculos(elementos);
            Array.Sort(vehiculos);

            foreach (Elemento elemento in elementos)
            {
                if (elemento is Vehiculo)
                {
                    Console.WriteLine((Vehiculo)elemento);
                }
            }
        }

        public static void ActivarInactivos(Elemento[] elementos)
        {
            foreach (Elemento elemento in elementos)
            {
                if (!elemento.GetActivo())
                {
                    elemento.Activar();
                    Console.WriteLine(elemento);
                }
            }
        }

        public static void EstablecerAlturaDrones3m(Elemento[] elementos)
        {
            Dron[] drones = ObtenerDrones(elementos);
            foreach (Dron dron in drones)
            {
                dron.SetAltitud(3);
                Console.WriteLine(dron);
            }
        }

        public static EstacionCarga ObtenerEstacionMasCercana(ICargable cargable, EstacionCarga[] estaciones)
        {
            Vehiculo vehiculo = (Vehiculo)cargable;
            EstacionCarga estacionMasCercana = estaciones[0];
            int distanciaMinima = CalcularDistancia(vehiculo, estaciones[0]);

            foreach (EstacionCarga estacion in estaciones)
            {
                int distanciaActual = CalcularDistancia(vehiculo, estacion);
                if (distanciaActual < distanciaMinima)
                {
                    distanciaMinima = distanciaActual;
                    estacionMasCercana = estacion;
                }
            }

            return estacionMasCercana;
        }

        private static int CalcularDistancia(Vehiculo vehiculo, EstacionCarga estacion)
        {
            int x = vehiculo.GetX() - estacion.GetX();
            int y = vehiculo.GetY() - estacion.GetY();
            x = x < 0 ? -x : x;
            y = y < 0 ? -y : y;
                
            return x + y;
        }

        public static void MoverCargablesBajaBateria(Elemento[] elementos, EstacionCarga[] estaciones)
        {
            foreach (Elemento elemento in elementos)
            {
                int porcentajeBateria = -1;

                if (elemento is Dron dron)
                {
                    porcentajeBateria = dron.GetPorcentajeBateria();
                }
                else if (elemento is RobotReparto robot)
                {
                    porcentajeBateria = robot.GetPorcentajeBateria();
                }
                
                if (porcentajeBateria != -1 && porcentajeBateria < 20 && elemento is ICargable cargable)
                {
                    EstacionCarga estacionCercana = ObtenerEstacionMasCercana(cargable, estaciones);
                    if (estacionCercana != null)
                    {
                        Vehiculo vehiculo = (Vehiculo)elemento;
                        vehiculo.SetX(estacionCercana.GetX());
                        vehiculo.SetY(estacionCercana.GetY());
                        Console.WriteLine($"Llevando {vehiculo.GetNombre()} a cargar a {estacionCercana}");
                    }
                }
            }
        }

        public static void MostrarElementosInactivos(Elemento[] elementos)
        {
            foreach (Elemento elemento in elementos)
            {
                if (!elemento.GetActivo())
                {
                    Console.WriteLine(elemento);
                }
            }
        }
        public static void MostrarDronesOrdenadosPorAltitud(Elemento[] elementos)
        {
            Dron[] drones = ObtenerDrones(elementos);
            Array.Sort(drones, (d1, d2) => d1.GetAltitud().CompareTo(d2.GetAltitud()));
            foreach (Dron dron in drones)
            {
                Console.WriteLine(dron);
            }
        }

        public static void CapturarImagenesDrones(Elemento[] elementos)
        {
            foreach (Dron dron in ObtenerDrones(elementos))
            {
                dron.CapturaImagenes();
            }
        }

        public static void SwitchMenu(Elemento[] elementos)
        {  
            int entradaUsuario;
            
            do
            {
                MostrarOpciones();
                entradaUsuario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (entradaUsuario)
                {
                    case 1:
                        MostrarVehiculosOrdenados(elementos);
                        break;
                    case 2:
                        ActivarInactivos(elementos);
                        break;
                    case 3:
                        EstablecerAlturaDrones3m(elementos);
                        break;
                    case 4:
                        MoverCargablesBajaBateria(elementos, ObtenerEstaciones(elementos));
                        break;
                    case 5:
                        MostrarDronesOrdenadosPorAltitud(elementos);
                        break;
                    case 6:
                        MostrarElementosInactivos(elementos);
                        break;
                    case 7:
                        CapturarImagenesDrones(elementos);
                        break;
                    case 8 :
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            } while (entradaUsuario != 8);}
        static void Main(string[] args)
        {
            Elemento[] elementos =
            {
                new Auto("Auto1"),
                new Auto("Auto2"),
                new RobotReparto("RobotReparto1"),
                new RobotReparto("RobotReparto2"),
                new EstacionCarga("EstacionCarga1"),
                new EstacionCarga("EstacionCarga2"),
                new Dron("Dron1"),
                new Dron("Dron2"),
            };
            
            SwitchMenu(elementos);            
        }
    }
}
