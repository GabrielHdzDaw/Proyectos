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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
