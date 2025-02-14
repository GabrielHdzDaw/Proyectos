/* Autor: gabhercol
/* Fecha: 2/14/2025 11:48:02 AM
/* Descripción: 

Realiza un programa en C# para gestionar la cola del médico.

Se debe mostrar el siguiente menú:

1.- Siguiente Paciente
2.- Añadir un nuevo paciente.
3.- Mostrar próximo paciente.
4.- Mostrar todos los pacientes.
5.- Consultar un paciente.
6.- Borrar todos los pacientes.
S.- Salir

*/
namespace ProyectoColaMedico
{
    internal class Program
    {
        public static void SiguientePaciente(Queue<string> queue)
        {
            Console.WriteLine($"Siguiente paciente: {queue.Dequeue()}"); 
        }

        public static void AnadirPaciente(Queue<string> queue)
        {
            Console.Write("Introduce nombre del paciente: ");
            string paciente = Console.ReadLine(); 
            queue.Enqueue(paciente);
            Console.WriteLine($"Añadido paciente: {paciente}");
        }
        
        public static void MostrarProximoPaciente(Queue<string> queue)
        {
            Console.WriteLine($"Próximo paciente: {queue.Peek()}"); 
        }

        public static void MostrarTodosPacientes(Queue<string> queue)
        {
            foreach(string paciente in queue)
            {
                Console.WriteLine(paciente);
            }
        }

        public static void ConsultarPaciente(Queue<string> queue)
        {
            Console.Write("Introduce nombre del paciente a consultar: ");
            string paciente = Console.ReadLine();
            Console.WriteLine(queue.Contains(paciente) ? $"{paciente} sí está" : $"{paciente} no está");
        }

        public static void BorrarTodosLosPacientes(Queue<string> queue)
        {
            queue.Clear();
            Console.WriteLine("Todos los pacientes borrados");
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("1.- Siguiente Paciente\n2.- Añadir un nuevo paciente.\n3.- Mostrar próximo paciente.\n4.- Mostrar todos los pacientes.\n5.- Consultar un paciente.\n6.- Borrar todos los pacientes.\n7.- Salir");
            Console.Write("Introduce opción deseada: ");
        }

        public static void SwitchMenu(Queue<string> queue)
        {
            
            int entradaUsuario = 0;
            do
            {
                MostrarMenu();
                entradaUsuario = Convert.ToInt32(Console.ReadLine());
                switch (entradaUsuario)
                {
                    case 1:
                        SiguientePaciente(queue);
                        break;
                    case 2:
                        AnadirPaciente(queue);
                        break;
                    case 3:
                        MostrarProximoPaciente(queue);
                        break;
                    case 4:
                        MostrarTodosPacientes(queue);
                        break;
                    case 5:
                        ConsultarPaciente(queue);
                        break;
                    case 6:
                        BorrarTodosLosPacientes(queue);
                        break;
                    case 7:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (entradaUsuario != 7);
            
        }

        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            SwitchMenu(queue);
        }
    }
}
