/* Autor: gabhercol
/* Fecha: 1/23/2025 11:24:50 AM
/* Descripción: Crea una clase "Casa", con un atributo "area", un constructor que establezca su valor y un método ToString que 
devuelva una cadena: "Soy una casa, mi área es X m2". Incluye getters y setters para el area también.
    La casa contendrá una "puerta". Cada puerta tendrá un atributo "color" y un método ToString que devolverá la
siguiente cadena "Soy una puerta, mi color es X". Incluye el getter y setter para color. También crea un "GetPuerta" en la casa.
    Un "ApartamentoPequeño" una subclase de Casa, con un área prefijada de 50 m2.
    También crea una clase Persona, con un nombre. Cada persona tendrá una casa. El método ToString de una
persona devolverá su nombre, los datos de su casa y los datos de la puerta de su casa.
    Escribe un Main para crear un array de 2 personas, 1 tiene casa y la otra un apartamento pequeño


*/
namespace ProyectoCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Pepe");
            Persona persona2 = new Persona("Jose");
            Persona[] personas = { persona1, persona2 };


            persona1.GetCasa().SetArea(200);
            
            persona1.GetCasa().GetPuerta().SetColor("azul");
            persona2.GetCasa().GetPuerta().SetColor("verde");
            Console.WriteLine(persona1);
            Console.WriteLine(persona2);
            persona2.SetCasa(new Apartamento());
            Console.WriteLine(persona1);
            Console.WriteLine(persona2);

        }
    }
}
