/* Autor: gabhercol
/* Fecha: 2/24/2025 11:13:16 AM
/* Descripción: Vamos a crear una clase llamada Alumno con los datos: dni, nombre, apellidos, edad y una lista de notas (pondremos 3)

Leemos los datos de nombre apellidos y edad del fichero y el dni lo rellenais con un número aleatorio y las notas también.

Una vez creado todo esto vamos a hacer un menú con las siguientes opciones:

-- Le sumamos 10 a todas las edades.

-- Mostrar el alumno más viejo.

-- Mostrar todos los alumnos con sus notas.

-- Borrar todos los alumnos con nota media inferior a 5

-- Indica si todos los alumnos son mayores de 18

-- Indica si todos los alumnos han sacado más de un 7 de media.
*/
using System.Collections.Specialized;

namespace ProyectoListasAdicional
{
    internal class Program
    {
        public static void SumarEdad(List<Alumno> alumnos)
        {
            foreach (Alumno alumno in alumnos)
            {
                alumno.SetEdad(alumno.GetEdad() + 10);
            }
            Console.WriteLine("Edades sumadas");
        }

        public static void MostrarAlumnoMasViejo(List<Alumno> alumnos)
        {
            alumnos.Sort();
            Alumno alumnoMasViejo = alumnos[alumnos.Count() - 1];
        
            Console.WriteLine($"El alumno más viejo: {alumnoMasViejo}");
        }

        public static void MostrarAlumnos(List<Alumno> alumnos)
        {
            alumnos.ForEach(alumno => Console.WriteLine(alumno));
        }

        public static void BorrarAlumnosNotaInferior5(List<Alumno> alumnos)
        {
            alumnos.RemoveAll(alumno => alumno.GetMedia() < 5);
            Console.WriteLine("Alumnos borrados");
        }

        public static void IndicarMayores18(List<Alumno> alumnos)
        {
            bool todosMayores = alumnos.TrueForAll(alumno => alumno.GetEdad() >= 18);
            Console.WriteLine(todosMayores ? "Todos son mayores de edad" : "No todos son mayores de edad");
        }

        public static void IndicarMedia7(List<Alumno> alumnos)
        {
            bool todosMas7Media = alumnos.TrueForAll(alumno => alumno.GetMedia() > 7);
            Console.WriteLine(todosMas7Media ? "Todos tienen más de 7 de media" : "No todos tienen más de 7 de media");
        }
        //public static void IndicarMedia5(List<Alumno> alumnos)
        //{
        //   List<double> medias = alumnos.FindAll(alumno => alumno.GetMedia() > 5);
        //}

        public static void MostrarAlumnosPosterioresTexto(List<Alumno> alumnos)
        {
            Console.Write("Introduce texto:");
            string texto = Console.ReadLine();

            alumnos.FindAll(alumno => alumno.GetNombre().CompareTo(texto) > 0 ).ForEach(alumno => Console.WriteLine(alumno));

        }

        public static void MostrarAlumnosQueTienen5(List<Alumno> alumnos)
        {
            alumnos.ForEach(alumno => Console.WriteLine(alumno.Tiene5() ? $"{alumno.GetNombre()} tiene algún 5" : );
        }

        public static void OrdenarAlumnosPorEdad(List<Alumno> alumnos)
        {
            alumnos.Sort((a1, a2) =>
            {
                int res = a1.GetEdad().CompareTo(a2.GetEdad());
                if (res == 0)
                {
                    res = a1.GetNombre().CompareTo(a2.GetNombre());
                }
                return res;
            });
        }


        public static void MostrarAlumnosTerminanA(List<Alumno> alumnos)
        {
            alumnos.FindAll(alumno => alumno.GetNombre().EndsWith("a")).ForEach(alumno => Console.WriteLine(alumno));
        }
        public static void MostrarMenu()
        {
            Console.WriteLine("1. Le sumamos 10 a todas las edades.");
            Console.WriteLine("2. Mostrar el alumno más viejo.");
            Console.WriteLine("3. Mostrar todos los alumnos con sus notas.");
            Console.WriteLine("4. Borrar todos los alumnos con nota media inferior a 5.");
            Console.WriteLine("5. Indica si todos los alumnos son mayores de 18.");
            Console.WriteLine("6. Indica si todos los alumnos han sacado más de un 7 de media.");
            Console.WriteLine("7. Mostrar todos los alumnos cuyo nombre termine por 'a'");
            Console.WriteLine("8. Mostrar todos los alumnos cuya media de notas sea más de 5");
            Console.WriteLine("9. Mostrar todos los alumnos cuyo nombre sea posterior alfabéticamente a un texto introducido por el usuario");
            Console.WriteLine("0. Salir.");
            Console.Write("Introduce la opción deseada: ");
        }

        public static void SwitchMenu(List<Alumno> alumnos)
        {
            Console.WriteLine();
            int entradaUsuario = -1;
            do
            {
                MostrarMenu();
                entradaUsuario = Convert.ToInt32(Console.ReadLine());
                switch (entradaUsuario)
                {
                    case 1:
                        SumarEdad(alumnos);
                        break;
                    case 2:
                        MostrarAlumnoMasViejo(alumnos);
                        break;
                    case 3:
                        MostrarAlumnos(alumnos);
                        break;
                    case 4:
                        BorrarAlumnosNotaInferior5(alumnos);
                        break;
                    case 5:
                        IndicarMayores18(alumnos);
                        break;
                    case 6:
                        IndicarMedia7(alumnos);
                        break;
                    case 7:
                        MostrarAlumnosTerminanA(alumnos);
                        break;
                    case 8:
                        IndicarMedia5(alumnos);
                        break;
                    case 9:
                        MostrarAlumnosPosterioresTexto(alumnos);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.WriteLine();
            } while (entradaUsuario != 0);
            
        }
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>()
            {
                new Alumno("Gabriel", "Hernandez", 20),
                new Alumno("Juan", "Perez", 18),
                new Alumno("Maria", "Gonzalez", 17),
                new Alumno("Pedro", "Lopez", 19),
                new Alumno("Ana", "Martinez", 21),
                new Alumno("Luis", "Garcia", 22),
                new Alumno("Sara", "Fernandez", 23),
                new Alumno("Carlos", "Sanchez", 24),
                new Alumno("Laura", "Ramirez", 25),
                new Alumno("Pablo", "Torres", 26)
            };

            SwitchMenu(alumnos);
        }
    }
}
