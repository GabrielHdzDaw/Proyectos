/* Autor: gabhercol
/* Fecha: 2/21/2025 12:07:11 PM
/* Descripción: Realiza un programa en C# para gestionar una agenda.
Tendremos por un lado Contacto: nombre, puesto, empresa. Otra clase llamada Reunion: nombre,fecha y hora, Contacto.
Una clase llamada Agenda con :
 Una List<Contacto> con todos los contactos que se inicializarán en el constructor con algunos datos inventados.
Una List<Reunion> con las reuniones.
Para poder realizar esta instrucción: if(contactos.Contains(miContacto)) la clase contacto debe tener implementado el método Equals.
Crea a su vez un program con el siguiente menú:
1.- Ver todas las reuniones ordenadas por contacto.(Sort y .Foreach)
2.- Ver las reuniones de hoy.(FindAll y .Foreach)
3.- Ver las reuniones de la próxima semana. (7 días desde hoy) (FindAll y .Foreach)
4.-Ver todos los contactos ordenados por empresa y nombre (Sort y Foreach)
5.- Añadir una nueva reunión
6.- Borrar una reunión
7.- Mover todas las reuniones un día. (ConvertAll)
8.- Listar todos los contactos de una empresa determinada. (FindAll)
9.- Mostrar todas la reuniones con una empresa determinada. (FindAll)
10. Cambiar el nombre de una empresa de los contactos. (ConvertAll)
11. Mostrar la próxima reunión (La más cercana al momento actual. Sort )
12. Muestra si tengo alguna reunión programada con una empresa.
13. Borrar todas las reuniones con un contacto determinado
*/
namespace ProyectoAgenda
{
    internal class Program
    {
        
        public static void MostrarMenu()
        {
            Console.WriteLine("1.- Ver todas las reuniones ordenadas por contacto.");
            Console.WriteLine("2.- Ver las reuniones de hoy.");
            Console.WriteLine("3.- Ver las reuniones de la próxima semana.");
            Console.WriteLine("4.- Ver todos los contactos ordenados por empresa y nombre.");
            Console.WriteLine("5.- Añadir una nueva reunión.");
            Console.WriteLine("6.- Borrar una reunión.");
            Console.WriteLine("7.- Mover todas las reuniones un día.");
            Console.WriteLine("8.- Listar todos los contactos de una empresa determinada.");
            Console.WriteLine("9.- Mostrar todas la reuniones con una empresa determinada.");
            Console.WriteLine("10.- Cambiar el nombre de una empresa de los contactos.");
            Console.WriteLine("11.- Mostrar la próxima reunión.");
            Console.WriteLine("12.- Muestra si tengo alguna reunión programada con una empresa.");
            Console.WriteLine("13.- Borrar todas las reuniones con un contacto determinado.");
            Console.WriteLine("0.- Salir.");
            Console.WriteLine("\nIntroduce la opción deseada: ");
        }

        public static void SwitchMenu(Agenda agenda)
        {
            int entradaUsuario = -1;

            do
            {
                MostrarMenu();
                entradaUsuario = Convert.ToInt32(Console.ReadLine());

                switch (entradaUsuario)
                {
                    case 1:
                        agenda.MostrarReunionesOrdenadas();
                        break;
                    case 2:
                        agenda.VerReunionesHoy();
                        break;
                    case 3:
                        agenda.MostrarReunionesProximaSemana();
                        break;
                    case 4:
                        agenda.MostrarContactosOrdenados();
                        break;
                    case 5:
                        agenda.AnadirReunion();
                        break;
                    case 6:
                        agenda.BorrarReunion();
                        break;
                    case 7:
                        agenda.MoverReuniones1Dia();
                        break;
                    case 8:
                        // Listar todos los contactos de una empresa determinada.
                        break;
                    case 9:
                        // Mostrar todas la reuniones con una empresa determinada.
                        break;
                    case 10:
                        // Cambiar el nombre de una empresa de los contactos.
                        break;
                    case 11:
                        // Mostrar la próxima reunión.
                        break;
                    case 12:
                        // Muestra si tengo alguna reunión programada con una empresa.
                        break;
                    case 13:
                        // Borrar todas las reuniones con un contacto determinado.
                        break;
                    default:
                        break;
                }

            } while (true);
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
