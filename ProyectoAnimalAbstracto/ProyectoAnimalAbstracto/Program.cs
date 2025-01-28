/* Autor: gabhercol
/* Fecha: 1/23/2025 12:37:18 PM
/* Descripción: 
*/
namespace ProyectoAnimalAbstracto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro1 = new Perro("Bobby", 10);
            Pato pato1 = new Pato("José Luis",20);
            Perro perro2 = new Perro("Azafrán",3);
            Pato pato2 = new Pato("Cuaquers",6);
            Perro perro3 = new Perro("Bon Jovi", 12);
            Pato pato3 = new Pato("Maravilla", 25);
            Perro perro4 = new Perro("Rodolfo",13);
            Animal[] animales = { perro1, pato1, perro2, pato2, perro3, pato3, perro4 };


            Array.Sort(animales, (a1, a2) => a1.GetEdad().CompareTo(a2.GetEdad())); //No es necesario que la clase Animal implemente IComparable
            Console.WriteLine("Animales ordenados por edad");
            foreach (Animal animal in animales)
            {
                Console.WriteLine(animal);
            }
            Array.Sort(animales); //Necesario que la clase Animal implemente IComparable
            Console.WriteLine("\nAnimales ordenados por nombre");
            foreach (Animal animal in animales)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
