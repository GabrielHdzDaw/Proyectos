/* Autor: gabhercol
/* Fecha: 1/31/2025 12:11:03 PM
/* Descripción: Queremos crear un “simulador de instituto”.

En una primera aproximación distinguiremos tres tipos de personas: alumno, profesor y conserje. También tendremos aulas, a las que asistirán los alumnos.

Cada persona tendrá un nombre, una edad, un (único) constructor que dé valor a ambos campos, un método “MostrarEstado” y 
un método “Animar15minutos”, cuyo cometido se detalla más adelante. Además, los alumnos tendrán como atributo el número 
de Aula (por ejemplo, la 2) a la que asisten. Todos los atributos estarán accesibles a través de métodos Get y Set. Para 
los alumnos existirá un segundo constructor, que reciba también el aula asignada, y que se apoyará en el otro constructor de la misma clase.

El simulador creará un conserje, dos profesores y cinco alumnos (todos ellos como parte de un único “array”). También
creará dos aulas. Asignará nombre y edad a cada persona (que no se pedirán al usuario, sino que estarán predefinidos 
en la simulación) y comenzará la simulación en las 0.00h de la noche del sábado al domingo. La simulación avanzará en 
intervalos de 15 minutos. Para ello, llamará al método “Animar15minutos” de cada una de las personas que intervienen 
en la simulación, de modo que actualicen su “reloj interno”, y luego llamará al método “MostrarEstado” de cada persona, 
para que escriban su nombre y la actividad que está realizando. Cuando el usuario pulse “Intro”, se volverá a avanzar 15 minutos y a mostrar el estado, y así sucesivamente.

Para que la simulación sea más real, cada persona puede tener una secuencia de acciones que no sea exactamente igual 
a la de los demás (ya sea aleatoria o prefijada). Por ejemplo, un alumno podría levantarse a las 08.15h, mientras que 
otro lo hiciera a las 10h o un conserje lo hiciera a las 06.45h).

Por ejemplo, un fragmento de la ejecución del programa (que pretende dar ideas, pero no es necesario seguir de forma estricta) 
con dos personas y un aula podría ser:

Lunes 14.45h
- Juan: casa
- Carlos: hacia el instituto
- Aula 1: (nadie)

Lunes 15.00h
- Juan: hacia el instituto
- Carlos: clase
- Aula 1: Carlos

Lunes 15.15h
- Juan: clase
- Carlos: clase
- Aula 1: Carlos Juan
*/
namespace ProyectoSimuladorInstituto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2025, 1, 1, 0, 0, 0);

            string hora = fecha.ToString("HH:mm");
            string dia = fecha.ToString("dddd");

            Persona[] personas = {
                new Conserje("Conserje", 50),
                new Profesor("Profesor1", 40),
                new Profesor("Profesor2", 45),
                new Alumno("Alumno1", 15, 1),
                new Alumno("Alumno2", 16, 1),
                new Alumno("Alumno3", 17, 1),
                new Alumno("Alumno4", 18, 2),
                new Alumno("Alumno5", 19, 2)
            };

            Alumno[] alumnosAula1 = { (Alumno)personas[3], (Alumno)personas[4], (Alumno)personas[5] };
            Alumno[] alumnosAula2 = { (Alumno)personas[6], (Alumno)personas[7] };

            Aula aula1 = new Aula(1, alumnosAula1);
            Aula aula2 = new Aula(2, alumnosAula2);

            while (true)
            {
                Console.WriteLine($"{dia} {hora}");
                foreach (Persona persona in personas)
                {
                    persona.Animar15minutos(fecha);
                    persona.MostrarEstado();
                }
                if(fecha.Hour > 7 && fecha.Hour <= 15)
                {
                    Console.WriteLine(aula1);
                    Console.WriteLine(aula2);
                }
                Console.ReadLine();
                fecha = fecha.AddMinutes(15);
                hora = fecha.ToString("HH:mm");
                dia = fecha.ToString("dddd");
                Console.Clear();
            }
        }
    }
}
