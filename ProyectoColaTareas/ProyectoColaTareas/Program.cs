/* Autor: gabhercol
/* Fecha: 3/11/2025 11:20:59 AM
/* Descripción: Lee de un fichero una serie de tareas (string) que se guardarán en una cola. Si el fichero no existe se inicia con la cola vacía.

Se muestran las tareas actuales.(Si no hay se escribirá en pantalla "No hay tareas")
Se muestra el siguiente menú:
-- Realizar tarea (se desencola la tarea actual y se muestra por pantalla el contenido)
-- Crear tarea nueva ( se encola la tarea que introduzca el usuario)
-- Mostrar tareas pendientes
-- Fin
Cuando se termine se guardan las tareas en el fichero. (Se sobreescribirá si existía)
*/
namespace ProyectoColaTareas
{
    internal class Program
    {
        public static void RealizarTarea(Queue<string> cola)
        {
            if (cola.Count > 0)
            {
                Console.WriteLine(cola.Dequeue());
                Console.WriteLine("Tarea realizada");
            }
            else
            {
                Console.WriteLine("No hay tareas pendientes");
            }
            
        }

        public static void CrearTarea(Queue<string> cola)
        {
            Console.Write("Introduce tarea: ");
            string entradaUsuario = Console.ReadLine();
            cola.Enqueue(entradaUsuario);
        }

        public static void MostrarTareas(Queue<string> cola)
        {
            foreach (string tarea in cola)
            {
                Console.WriteLine(tarea);
            }
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("1. Realizar tarea");
            Console.WriteLine("2. Crear tarea nueva");
            Console.WriteLine("3. Mostrar tareas pendientes");
            Console.WriteLine("4. Fin");
            Console.Write("Introduce la opción deseada: ");
        }

        public static void GuardarTareas(Queue<string> cola)
        {
            File.WriteAllLines(@"..\..\..\tareas.txt", cola);
        }

        public static void SwitchMenu(Queue<string> cola)
        {
            int entradaUsuario = 0;
            do
            {
                MostrarMenu();
                entradaUsuario = Convert.ToInt32(Console.ReadLine());
                switch (entradaUsuario)
                {
                    case 1:
                        RealizarTarea(cola);
                        break;
                    case 2:
                        CrearTarea(cola);
                        break;
                    case 3:
                        MostrarTareas(cola);
                        break;
                    case 4:
                        Console.WriteLine("Guardando tareas y saliendo...");
                        GuardarTareas(cola);
                        break;
                }
            }
            while (entradaUsuario != 4);
            
        }
        static void Main(string[] args)
        {
            if (!File.Exists(@"..\..\..\tareas.txt"))
            {
                Console.WriteLine("No hay tareas");
                StreamWriter fichero = File.CreateText(@"..\..\..\tareas.txt");
                Queue<string> colaTareas = new Queue<string>();
                fichero.Close();
                MostrarTareas(colaTareas);
                SwitchMenu(colaTareas);
            }
            else
            {
                try
                {
                    string[] tareas = File.ReadAllLines(@"..\..\..\tareas.txt");
                    Queue<string> colaTareas = new Queue<string>(tareas);
                    MostrarTareas(colaTareas);
                    SwitchMenu(colaTareas);
                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("El nombre del fichero es demasiado largo");
                }
                catch (IOException)
                {
                    Console.WriteLine("Ha habido un problema al escribir o leer el archivo");
                }   
            }
            ;
        }
    }
}
