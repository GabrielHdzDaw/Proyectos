/* Autor: gabhercol
/* Fecha: 1/28/2025 11:52:14 AM
/* Descripción: En el proyecto anterior de Alumno añade el dato DNI al alumno e implementa el método 
equals que indique que 2 alumnos serán iguales si tienen el mismo DNI.

A continuación sobrecarga los operadores == y != para la clase Alumno.
En un programa de prueba crea un menú para pedirle 5 alumnos al usuario e introducirlos
en un array, comprobando previamente que el alumno proporcionado no está ya en el array.
*/
namespace ProyectoIcomparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno[] alumnos = new Alumno[5];

            for (int i = 0; i < alumnos.Length; i++)
            {
                bool repetido = false;
                do
                {
                    repetido = false;
                    Console.Write($"Introduce nombre de alumno {i + 1}:");
                    string nombre = Console.ReadLine();
                    Console.Write($"Introduce DNI de alumno {i + 1}:");
                    string dni = Console.ReadLine();
                    Console.Write($"Introduce edad de alumno {i + 1}:");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Introduce curso de alumno {i + 1}:");
                    string curso = Console.ReadLine();
                    Alumno temp = new Alumno(nombre, dni, edad, curso);

                    foreach (Alumno alumno in alumnos)
                    {
                        if (temp == alumno)
                        {
                            repetido = true;
                            Console.WriteLine("El alumno ya está en array.");
                        }
                    }
                    if (!repetido)
                    {
                        alumnos[i] = temp;
                    }
                } while (repetido);
            }
        }
    }
}
