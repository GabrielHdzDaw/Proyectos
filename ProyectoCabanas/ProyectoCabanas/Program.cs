/* Autor: gabhercol
/* Fecha: 2/7/2025 12:19:41 PM
/* Descripción: Vamos a realizar el proceso de reparto de alumnos entre las cabañas en un campamento
de verano. La lista de alumnos disponibles la rellenáis en el código con al menos 50
niños. De cada alumno guardaremos: nombre, apellidos,teléfono, edad.
La lista de cabañas la creáis también en el código y deben ser al menos 3. De cada
cabaña guardaremos su nombre, edad de los alumnos y la lista de componentes de la
cabaña(monitor+niños)
Los monitores también los creáis en el código y deben ser al menos 3. De cada monitor
guardaremos su nombre y especialidad (edad de los niños que cuidará)
En cada cabaña habrá un monitor y 20 niños. Los niños de cada cabaña deberán haber
nacido en el mismo año. El monitor se añadirá en la posición 0 del array y el resto de
posiciones serán para los alumnos.
Se deberá ir recorriendo la lista de alumnos disponibles para ir rellenando las cabañas
una a una, y para cada cabaña asignar un monitor con la especialidad adecuada. Cuando
no nos queden alumnos para repartir habremos terminado y se mostrará un menú con las
opciones de:
• Consultar los componentes de alguna cabaña que deberán aparecer ordenados
por apellidos y nombre (implementar IComparable). Aparecerá primero el monitor
en la primera línea junto con la edad de la cabaña y luego los alumnos de la
cabaña con el siguiente formato:
◦ Apellidos, Nombre : Telefono.
• Añadir alumno nuevo a la cabaña (siempre que quepa)
• Eliminar un alumno de una cabaña
• Ver el nombre del monitor de las cabañas y el nombre de cabaña asignado.
Recordad que se tendrá en cuenta, la eficiencia, el código limpio y el tamaño de los
métodos.
*/

namespace ProyectoCabanas
{
    internal class Program
    {
        public static int[] ObtenerEspecialidades(Alumno[] alumnos)
        {
            int[] temp = new int[alumnos.Length];
            int contador = 0;

            foreach (Alumno alumno in alumnos)
            {
                int edadActual = alumno.GetEdad();
                bool existe = false;

                for (int j = 0; j < contador; j++)
                {
                    if (temp[j] == edadActual)
                    {
                        existe = true;
                    }
                }

                if (!existe)
                {
                    temp[contador] = edadActual;
                    contador++;
                }
            }

            
            int[] especialidades = new int[contador];
            for (int i = 0; i < contador; i++)
            {
                especialidades[i] = temp[i];
            }
            return especialidades;
        }

        public static Monitor[] CrearArrayMonitores(int[] especialidades)
        {
            
            Monitor[] monitores = new Monitor[especialidades.Length];
            for (int i = 0; i < monitores.Length; i++)
            {
                monitores[i] = new Monitor($"Nombre{i}", $"Apellido{i}", new DateTime(1990 + i, 1, 1), especialidades[i]);
            }
            return monitores;
        }

        public static Alumno[] CrearArrayAlumnos(int length)
        {
            DateTime fechaNacimiento1 = new DateTime(2010, 1, 1);
            DateTime fechaNacimiento2 = new DateTime(2013, 1, 1);
            DateTime fechaNacimiento3 = new DateTime(2017, 1, 1);
            Alumno[] alumnos = new Alumno[length];
            
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (i < 20)
                {
                    alumnos[i] = new Alumno($"Nombre{i}", $"Apellido{i}", fechaNacimiento1, Convert.ToInt32($"605123{(i % 1000):D3}"));
                }
                else if (i < 40)
                {
                    alumnos[i] = new Alumno($"Nombre{i}", $"Apellido{i}", fechaNacimiento2, Convert.ToInt32($"605123{(i % 1000):D3}"));
                }
                else
                {
                    alumnos[i] = new Alumno($"Nombre{i}", $"Apellido{i}", fechaNacimiento3, Convert.ToInt32($"605123{(i % 1000):D3}"));
                }
            }
            return alumnos;
        }

        public static Cabana[] CrearArrayCabanas(Monitor[] monitores, Alumno[] alumnos, int alumnosPorCabana)
        {
            Cabana[] cabanas = new Cabana[monitores.Length];
            int totalAlumnos = alumnos.Length;
            int alumnosAsignados = 0;

            for (int i = 0; i < cabanas.Length && alumnosAsignados < totalAlumnos; i++)
            {
                int alumnosCabana = Math.Min(alumnosPorCabana, totalAlumnos - alumnosAsignados);

                Persona[] componentes = new Persona[alumnosCabana + 1];
                componentes[0] = monitores[i];

                for (int j = 1; j <= alumnosCabana; j++)
                {
                    componentes[j] = alumnos[alumnosAsignados];
                    alumnosAsignados++;
                }

                cabanas[i] = new Cabana($"Cabana{i}", monitores[i].GetEspecialidad(), componentes);
            }

            return cabanas;
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("1. Consultar los componentes de alguna cabaña");
            Console.WriteLine("2. Añadir alumno nuevo a la cabaña");
            Console.WriteLine("3. Eliminar un alumno de una cabaña");
            Console.WriteLine("4. Ver el nombre del monitor de las cabañas y el nombre de cabaña asignado");
            Console.WriteLine("s. Salir");
        }

        public static char ObtenerOpcion()
        {
            char opcion;
            do
            {
                Console.Write("Introduce una opción: ");
                opcion = Convert.ToChar(Console.ReadLine());
            } while (opcion != '1' && opcion != '2' && opcion != '3' && opcion != '4' && opcion != 's');
            return opcion;
        }

        public static void SwitchMenu(Cabana[] cabanas)
        {
            char entradaUsuario;
            do
            {
                MostrarMenu();
                entradaUsuario = ObtenerOpcion();
                Console.WriteLine();
                switch (entradaUsuario)
                {
                    case '1':
                        int numeroCabanas = cabanas.Length;
                        Console.Write($"Introduce el número de la cabaña que quieres consultar ({numeroCabanas} cabañas): ");
                        int numeroCabana = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Monitor: {cabanas[numeroCabana - 1].GetComponentes()[0]}");
                        Array.Sort(cabanas[numeroCabana - 1].GetComponentes());
                        foreach (Persona componente in cabanas[numeroCabana - 1].GetComponentes())
                        {
                            if (componente is not Monitor)
                            {
                                Console.WriteLine(componente);
                            }
                        }
                        break;
                    case '4':
                        foreach (Cabana cabana in cabanas)
                        {
                            Console.WriteLine($"Monitor: {cabana.GetComponentes()[0]} | Nombre de la cabaña: {cabana.GetNombre()}");
                        }
                        break;
                }
                Console.WriteLine();
            } while (entradaUsuario != 's');
            
            
        }
        public static void Main(string[] args)
        {
            Alumno[] alumnos = CrearArrayAlumnos(50);
            int[] especialidades = ObtenerEspecialidades(alumnos);
            Monitor[] monitores = CrearArrayMonitores(especialidades);
            Cabana[] cabanas = CrearArrayCabanas(monitores, alumnos, 20);
            char entradaUsuario;
            SwitchMenu(cabanas);
        }
    }
}
