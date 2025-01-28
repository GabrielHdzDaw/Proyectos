/* Autor: gabhercol
/* Fecha: 1/28/2025 11:52:14 AM
/* Descripción: Realiza una clase llamada Alumno que tiene como atributos: nombre, edad, curso. Sus getters y sus setters
y implementa el interface IComparable(ordenamos por edad).

En un Main deberás hacer un array de 5 alumnos, rellenas los datos en el código y lo ordenas con Array.Sort(nombreArray)
Añade al proyecto anterior 2 Sorts más donde se ordenen los alumnos por nombre descendente y por curso ascendente. Muestra el array tras cada ordenación.
*/
namespace ProyectoIcomparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno[] alumnos = {
                new Alumno("Ronaldinho", 20, "1º"),
                new Alumno("Pepe", 55, "2º"),
                new Alumno("Aurora", 19, "3º"),
                new Alumno("Maria", 36, "4º"),
                new Alumno("Jose", 23, "5º")
            };

            Array.Sort(alumnos, (a1, a2) => a2.GetNombre().CompareTo(a1.GetNombre()));
            Console.WriteLine("\nAlumnos ordenados por nombre");
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno);
            }

            Array.Sort(alumnos);
            Console.WriteLine("\nAlumnos ordenados por edad");
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno);
            }

            Array.Sort(alumnos, (a1, a2) => a1.GetCurso().CompareTo(a2.GetCurso()));
            Console.WriteLine("\nAlumnos ordenados por curso");
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno);
            }
        }
    }
}
