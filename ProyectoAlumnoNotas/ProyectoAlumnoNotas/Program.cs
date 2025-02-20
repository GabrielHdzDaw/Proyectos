/* Autor: gabhercol
/* Fecha: 2/20/2025 11:58:50 AM
/* Descripción: Crea un proyecto llamado MD_E1, con los siguientes elementos:

    Crea una clase Alumno que almacene datos de los alumnos de un centro. De cada uno almacenaremos su DNI (string), su nombre (string) y una lista de notas (float).
    En el programa principal, crearemos un diccionario genérico cuyas claves serán los DNIs de los alumnos, y cuyos valores serán los alumnos almacenados. Es decir, crearemos un Dictionary<string,Alumno>.
Le pediremos al usuario que vaya introduciendo datos de alumnos: primero su DNI, luego su nombre, y luego una lista de notas separadas por espacios.
Cuando el usuario escriba "Fin" como DNI, terminaremos de introducir datos

    Crea una clase Alumno que almacene datos de los alumnos de un centro. De cada uno almacenaremos su DNI (string), su nombre (string) y una lista de notas (float).
    En el programa principal, crearemos un diccionario genérico cuyas claves serán los DNIs de los alumnos, y cuyos valores serán los alumnos almacenados. Es decir, crearemos un Dictionary<string,Alumno>.
    Le pediremos al usuario que vaya introduciendo datos de alumnos: primero su DNI, luego su nombre, y luego una lista de notas separadas por espacios.
    Cuando el usuario escriba "Fin" como DNI, terminaremos de introducir datos, y mostraremos un listado de los alumnos introducidos, mostrando su nombre y la media calculada de sus notas.

*/
using System.Diagnostics.CodeAnalysis;

namespace ProyectoAlumnoNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dni = "";
            List<Alumno> alumnos = new List<Alumno>();
            do
            {
                Console.Write("Introduce DNI del alumno: ");
                dni = Console.ReadLine();
                if (dni != "Fin")
                {
                    Console.Write("Introduce nombre del alumno: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Introduce notas del alumno separadas por espacios: ");
                    string[] notas = Console.ReadLine().Split(' ');
                    
                    List<float> notasAlumno = new List<float>();
                    foreach (string nota in notas)
                    {
                        notasAlumno.Add(Convert.ToSingle(nota));
                    }
                    alumnos.Add(new Alumno(dni, nombre, notasAlumno));
                }
                Console.WriteLine("------");
            } while (dni != "Fin");

            Dictionary<string, Alumno> diccionarioAlumnos = new Dictionary<string, Alumno>();

            foreach(Alumno alumno in alumnos)
            {
                diccionarioAlumnos.Add(alumno.GetDni(), alumno);
            }

            foreach (KeyValuePair<string, Alumno> alumno in diccionarioAlumnos)
            {
                Console.WriteLine($"Nombre: {alumno.Value.GetNombre()}, Media: {alumno.Value.CalcularMedia()}");
            }
        }
    }
}
