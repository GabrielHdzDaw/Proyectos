using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuelaV2
{
    internal abstract class Persona
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public Persona(string nombre, string direccion, DateTime fechaNacimiento, string localidad, string provincia)
        {
            Nombre = nombre;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Localidad = localidad;
            Provincia = provincia;
        }


        public static void CrearPersona()
        {
            Console.Write("Escoge rol (1. Profesor  2.Estudiante):");
            int entradaUsuario = int.Parse(Console.ReadLine());
            string rol = "";
            switch (entradaUsuario)
            {
                case 1:
                    rol = "Profesor";
                    break;
                case 2:
                    rol = "Estudiante";
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            Console.Write("Introduce el nombre:");
            string nombre = Console.ReadLine();
            Console.Write("Introduce la dirección:");
            string direccion = Console.ReadLine();
            Console.Write("Introduce la fecha de nacimiento (dd-mm-yyyy):");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.Write("Introduce la localidad:");
            string localidad = Console.ReadLine();
            Console.Write("Introduce la provincia:");
            string provincia = Console.ReadLine();

            switch (rol)
            {
                case "Profesor":
                    Console.Write("Introduce las asignaturas separadas por comas:");
                    string asignaturas = Console.ReadLine();
                    List<string> asignaturasList = asignaturas.Split(',').ToList();
                    Profesor profesor = new Profesor(nombre, direccion, fechaNacimiento, localidad, provincia, asignaturasList);
                    Console.WriteLine(profesor);
                    break;
                case "Estudiante":
                    Console.Write("Introduce las asignaturas y notas separadas por comas:");
                    string asignaturasNotas = Console.ReadLine();
                    Dictionary<string, double> asignaturasNotasDict = new Dictionary<string, double>();
                    string[] asignaturasNotasArray = asignaturasNotas.Split(',');
                    foreach (string asignaturaNota in asignaturasNotasArray)
                    {
                        string[] asignaturaNotaArray = asignaturaNota.Split(':');
                        string asignatura = asignaturaNotaArray[0];
                        double nota = double.Parse(asignaturaNotaArray[1]);
                        asignaturasNotasDict.Add(asignatura, nota);
                    }
                    Estudiante estudiante = new Estudiante(nombre, direccion, fechaNacimiento, localidad, provincia, asignaturasNotasDict);
                    Console.WriteLine(estudiante);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{rol} añadido");
        }

        public static void BorrarPersona(List<Persona> lista)
        {
            Console.Write("Introduce el nombre de la persona a borrar:");
            string nombre = Console.ReadLine();
            lista.RemoveAt(lista.FindIndex(p => p.Nombre == nombre));
            Console.WriteLine($"{nombre} borrado");
        }

        

        
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Dirección: {Direccion}, Fecha nac.: {FechaNacimiento.ToString("dd/MM/yyyy")}, Localidad: {Localidad}, Provincia: {Provincia},";
        }
    }
}
