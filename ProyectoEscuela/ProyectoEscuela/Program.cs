//Autor: Gabriel Hernández Collado
//Fecha: 27/3/2025
//Descripción: Habrá una clase Persona con los datos: nombre, dirección, fecha de nacimiento, localidad,provincia.


//Tenemos 2 tipos de personas, Profesor y Estudiante. El Profesor tiene como dato adicional una Lista de asignaturas.
//El Estudiante tiene como dato adicional un Dictionary donde la clave es el nombre de una asignatura y el value será la nota de esa asignatura.

//Crea un proyecto para mantener estos datos:

//Habrá una lista de personas, los datos se leerán de 2 ficheros, uno llamado estudiantes.txt y otro llamado profesores.txt.

//Contenido de estudiantes.txt

//Cada línea representará un estudiante con los siguientes campos separados por punto y coma (;):

//    Nombre
//    Dirección
//    Fecha de Nacimiento
//    Localidad
//    Provincia
//    Asignaturas y notas (en formato asignatura1:nota1, asignatura2:nota2,...)

//Contenido de profesores.txt

//Cada línea representará un profesor con los siguientes campos separados por punto y coma (;):

//    Nombre
//    Dirección
//    Fecha de Nacimiento
//    Localidad
//    Provincia
//    Asignaturas (separadas por comas)


namespace ProyectoEscuela
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
        static void Main(string[] args)
        {
            MostrarPersonas(RellenarListaPersonas());
        }
    }
}
