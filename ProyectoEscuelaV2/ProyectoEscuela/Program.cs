//Autor: Gabriel Hernández Collado
//Fecha: 27/3/2025
//Descripción:
//1.- Crear una nueva persona (Estudiante o profesor)

//2.- Borrar una persona

//3.- Mostrar todos los estudiantes matriculados en la asignatura...

//4.- Mostrar todos los profesores que imparten la asignatura...

//5.- Mostrar el estudiante con la media más alta

//6.- Mostrar todos los estudiantes matriculados en la asignatura... ordenados por la nota de esa asignatura

//7.- Mostrar los profesores que imparten más de 2 asignaturas ordenados alfabeticamente.

//8.- Mostrar los estudiantes de más de 16 años.

//9.- Mostrar los profesores cuyo año de nacimiento es posterior a 1990

//10.- Mostrar todos los alumnos matriculados en "programación" de una localidad pedida al usuario ordenados por dirección


namespace ProyectoEscuelaV2
{
    internal class Program
    {
        public static void AnadirEstudiantes(string[] estudiantes, List<Persona> listaPersonas)
        {
            foreach (string linea in estudiantes)
            {
                string[] campos = linea.Split(';');
                string nombre = campos[0];
                string direccion = campos[1];
                DateTime fechaNacimiento = DateTime.Parse(campos[2]);
                string localidad = campos[3];
                string provincia = campos[4];
                Dictionary<string, double> asignaturas = new Dictionary<string, double>();
                string[] asignaturasNotas = campos[5].Split(',');
                foreach (string asignaturaNota in asignaturasNotas)
                {
                    string[] asignaturaNotaArray = asignaturaNota.Split(':');
                    string asignatura = asignaturaNotaArray[0];
                    double nota = double.Parse(asignaturaNotaArray[1]);
                    asignaturas.Add(asignatura, nota);
                }
                listaPersonas.Add(new Estudiante(nombre, direccion, fechaNacimiento, localidad, provincia, asignaturas));
            }
        }

        public static void AnadirProfesores(string[] profesores, List<Persona> listaPersonas)
        {
            foreach (string linea in profesores)
            {
                string[] campos = linea.Split(';');
                string nombre = campos[0];
                string direccion = campos[1];
                DateTime fechaNacimiento = Convert.ToDateTime(campos[2]);
                string localidad = campos[3];
                string provincia = campos[4];
                List<string> asignaturas = campos[5].Split(',').ToList();
                listaPersonas.Add(new Profesor(nombre, direccion, fechaNacimiento, localidad, provincia, asignaturas));
            }
        }
        public static List<Persona> RellenarListaPersonas()
        {
            string ficheroEstudiantes = @"..\..\..\estudiantes.txt";
            string ficheroProfesores = @"..\..\..\profesores.txt";
            List<Persona> listaPersonas = new List<Persona>();
            string[] lineasEstudiantes = File.ReadAllLines(ficheroEstudiantes);
            string[] lineasProfesores = File.ReadAllLines(ficheroProfesores);
            AnadirEstudiantes(lineasEstudiantes, listaPersonas);
            AnadirProfesores(lineasProfesores, listaPersonas);
            return listaPersonas;
        }

        public static void MostrarPersonas(List<Persona> personas)
        {
            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona);
            }
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("1.- Crear una nueva persona (Estudiante o profesor)");
            Console.WriteLine("2.- Borrar una persona");
            Console.WriteLine("3.- Mostrar todos los estudiantes matriculados en la asignatura...");
            Console.WriteLine("4.- Mostrar todos los profesores que imparten la asignatura...");
            Console.WriteLine("5.- Mostrar el estudiante con la media más alta");
            Console.WriteLine("6.- Mostrar todos los estudiantes matriculados en la asignatura... ordenados por la nota de esa asignatura");
            Console.WriteLine("7.- Mostrar los profesores que imparten más de 2 asignaturas ordenados alfabeticamente");
            Console.WriteLine("8.- Mostrar los estudiantes de más de 16 años");
            Console.WriteLine("9.- Mostrar los profesores cuyo año de nacimiento es posterior a 1990");
            Console.WriteLine("10.- Mostrar todos los alumnos matriculados en 'programación' de una localidad pedida al usuario ordenados por dirección");
            Console.WriteLine("0.- Salir");
            Console.Write("Escoge una opción:");
        }

        public static void SwitchMenu()
        {
            List<Persona> listaPersonas = RellenarListaPersonas();
            int opcion = -1;
            while (opcion != 0)
            {
                MostrarMenu();
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Persona.CrearPersona();
                        break;
                    case 2:
                        Persona.BorrarPersona(listaPersonas);
                        break;
                    case 3:
                        Console.Write("Introduce asignatura: ");
                        string asignatura = Console.ReadLine();
                        listaPersonas.Where(p => p is Estudiante).ToList().Where(p => ((Estudiante)p).
                        Asignaturas.ContainsKey(asignatura))
                            .ToList().ForEach(p => Console.WriteLine(p));
                        break;
                    case 4:
                        Console.Write("Introduce asignatura: ");
                        string asignatura2 = Console.ReadLine();
                        listaPersonas.Where(p => p is Profesor).ToList().Where(p => ((Profesor)p).Asignaturas.Contains(asignatura2))
                            .ToList().ForEach(p => Console.WriteLine(p));
                        break;
                    case 5:
                        listaPersonas.Where(p => p is Estudiante).ToList().Where(p => ((Estudiante)p).
                        Asignaturas.Values.Average() == listaPersonas.Where(p => p is Estudiante).
                        ToList().Max(p => ((Estudiante)p).Asignaturas.Values.Average()))
                            .ToList().ForEach(p => Console.WriteLine(p));
                        break;
                    case 6:
                        Console.Write("Introduce asignatura: ");
                        string asignatura3 = Console.ReadLine();
                        listaPersonas.Where(p => p is Estudiante).ToList().OrderBy(listaPersonas => ((Estudiante)listaPersonas).Asignaturas[asignatura3])
                            .ToList().Where(p => ((Estudiante)p).Asignaturas.ContainsKey(asignatura3)).ToList().ForEach(p => Console.WriteLine(p));
                        break;
                    case 7:

                        listaPersonas.Where(p => p is Profesor).ToList().Where(p => ((Profesor)p).Asignaturas.Count > 2).
                            OrderBy(p => p.Nombre).ToList().ForEach(p => Console.WriteLine(p));
                        break;
                    case 8:

                        listaPersonas.Where(p => p is Estudiante).ToList().Where(p => DateTime.Now.Year - p.FechaNacimiento.Year > 16)
                            .ToList().ForEach(p => Console.WriteLine(p));
                        break;
                    case 9:
                        listaPersonas.Where(p => p.FechaNacimiento.Year > 1990).ToList().ForEach(p => Console.WriteLine(p));
                        break;
                    case 10:

                        Console.Write("Introduce localidad: ");
                        string localidad = Console.ReadLine();
                        listaPersonas.Where(p => p is Estudiante).ToList().Where(p => ((Estudiante)p).Asignaturas.ContainsKey("programación") && p.Localidad == localidad)
                            .OrderBy(p => p.Direccion).ToList().ForEach(p => Console.WriteLine(p));
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
            
        }
        public static void Main(string[] args)
        {
            SwitchMenu();
        }
    }
}
