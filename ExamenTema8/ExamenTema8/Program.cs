//Autor: Gabriel Hernández Collado
//Fecha: 21/3/2025
//Descripción: Crea una clase Tarea con los atributos: string descripción, booleano realizada. Con un
//constructor con todos sus parámetros y un método Realizar() que pondrá a true el atributorealizado. Además crearás un ToString que muestre sus datos de esta forma:
//Descripción—Realizada /No realizada
//En el Program crearás una lista de Tareas que sacará las descripciones del fichero tareas.txt y se inicializarán todas como no realizadas.
//Se sacarán por pantalla ordenadas alfabéticamente y numeradas de forma que al usuario se le irá preguntando al usuario cuales se han realizado,
//se irán marcando como realizadas y actualizando el listado en pantalla.
//Cuando el usuario ponga “fin” como número de tarea, se terminará el programa y se
//guardarán en el mismo fichero tareas.txt, sobrescribiéndolo, las tareas que queden sin
//realizar.



namespace ExamenTema8
{
    internal class Program
    {
        public static List<Tarea> LeerTareas(string fichero)
        {
            List<Tarea> tareas = new List<Tarea>();
            try
            {
                string linea;
                StreamReader sr = File.OpenText(fichero);
                do
                {
                    linea = sr.ReadLine();
                    tareas.Add(new Tarea(linea, false));
                }
                while (linea != null);
                sr.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Hubo un error al leer el fichero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //tareas.Sort();
            return tareas;
        }

        public static void MostrarTareas(string fichero, List<Tarea> tareas)
        {
            string entradaUsuario;
            do
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tareas[i]}");   
                }
                Console.WriteLine("Escoge tarea a realizar (\"fin\" para terminar): ");

                entradaUsuario = Console.ReadLine();

                if(entradaUsuario != "fin")
                {
                    if (!tareas[Convert.ToInt32(entradaUsuario) - 1].GetRealizada())
                    {
                        tareas[Convert.ToInt32(entradaUsuario) - 1].Realizar();
                    }
                    else
                    {
                        Console.WriteLine("Ya has realizado esta tarea");
                    }
                }
                
            }
            while (entradaUsuario != "fin");
            ReescribirFichero(fichero, tareas);
        }

        public static void ReescribirFichero(string fichero, List<Tarea> tareas)
        {
            try
            {
                StreamWriter sw = File.CreateText(fichero);
                foreach (Tarea tarea in tareas)
                {
                    if (!tarea.GetRealizada())
                    {
                        sw.Write(tarea.GetDescripcion() + "\n");
                    }
                }
                sw.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Hubo un error al leer el fichero");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hubo un error: {e.Message}");
            }
        }
        static void Main(string[] args)
        {
            string fichero = @"..\..\..\tareas.txt";
            List<Tarea> tareas = LeerTareas(fichero);
            MostrarTareas(fichero, tareas);

        }
    }
}
