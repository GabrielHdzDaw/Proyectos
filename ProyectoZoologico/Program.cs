/* Autor: $username$
   Fecha: $date$
   Descripción:
Ejercicio: Animales y Hábitat
. Crea una clase Animal con los atributos nombre y tipoAlimentacion (herbívoro, carnívoro,
omnívoro).
Incluye un método toString que describa al animal como: "Soy un [nombre] y soy
[tipoAlimentacion]".
. Cada animal tendrá un atributo habitat, representado por una clase Habitat, con un atributo
nombre (bosque, sabana, océano, etc.) y un método toString que diga: "Vivo en el/la [nombre del
hábitat]".
. Crea una subclase Pez de Animal con el tipo de alimentación fijo como "carnívoro".
. Crea una clase Zoológico, que contiene una lista de animales (un array).
. El método toString de Zoológico debe devolver una lista con la descripción de cada animal y su
hábitat.
. En el método main, crea un zoológico con tres animales (un array):
Un león en la sabana.
Un pez en el océano.
Un oso en el bosque.
*/

namespace ProyectoZoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Animal leon = new Animal("león", "carnívoro", new Habitat("sabana"));
            Pez pez = new Pez();
            Animal oso = new Animal("oso", "carnívoro", new Habitat("bosque"));
            Animal[] animales = { leon, pez, oso};

            Zoologico zoo = new Zoologico(animales);

            Console.WriteLine(zoo);
        }
    }
}
