/* Autor: gabhercol
/* Fecha: 3/11/2025 12:06:13 PM
/* Descripción: Realiza un programa de C# para controlar el inventario del Material Escolar de una escuela. 
De este material escolar guardaremos "nombre","marca","precio". El inventario es una clase llamada Inventario
con una SortedList <Material,int> donde guardamos cada material con la cantidad que tenemos de ese material.
Se deberá implementar el interface IComparer cuyo método a sobreescribir es Compare(objeto a, objeto b), el 
IComparable y  también el método Equals. El IComparer es para que la SortedList pueda estar ordenada correctamente 
y el equals es para poder acceder por la clave que es un objeto correctamente. Dos elementos serán iguales si
tienen el mismo nombre y marca y se ordenan también por nombre y marca.
El inventario se creará en el constructor de la clase con algunos ejemplos.

...

Habrá un menú para actualizar el inventario que nos permitirá :

añadir material nuevo

Actualizar cantidad de material existente.

Listar los materiales ordenados
*/
namespace ProyectoMaterialEscolar
{
    internal class Program
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("1. Añadir material nuevo");
            Console.WriteLine("2. Actualizar cantidad de material existente");
            Console.WriteLine("3. Listar los materiales ordenados");
            Console.WriteLine("4. Salir");
        }

        public sta
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            int entradaUsuario = 0;
            do
            {
                MostrarMenu();
                switch (entradaUsuario)
                {
                    case 1:
                        inventario.AnadirMaterial();
                }

            } while (entradaUsuario != 4);
            

        }
    }
}
