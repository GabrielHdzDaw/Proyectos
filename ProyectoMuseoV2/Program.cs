/* Autor: gabri
/* Fecha: 28/01/2025 20:07:25
/* Descripción: 
Añade al proyecto Museo 2 opciones más
-- Listar todas las obras ordenadas por propietario
-- Listar las esculturas ordenadas por fecha
-- Listar todas las obras ordenadas por el nombre del autor.
*/
namespace ProyectoMuseoV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autor leonardo = new Autor("Leonardo Da Vinci");
            Autor miguel = new Autor("Miguel Ángel");
            Autor vanGogh = new Autor("Vincent Van Gogh");
            Autor auguste = new Autor("Auguste Rodin");
            Autor picasso = new Autor("Pablo Picasso");
            Autor henry = new Autor("Henry Moore");
            Obra[] obras = { 
                new Pintura(leonardo, "Museo del Louvre", "La Gioconda", 1503),
                new Escultura(miguel, "Museo del Vaticano", "David", 1504, "Mármol"),
                new Pintura(vanGogh, "Museo Van Gogh", "Los Girasoles", 1888),
                new Escultura(auguste, "Museo Rodin", "El Pensador", 1902, "Bronce"),
                new Pintura(picasso, "Museo Picasso", "Guernica", 1937),
                new Escultura(henry, "Museo Henry Moore", "Reclining Figure", 1951, "Bronce")
            };

            Array.Sort(obras, (o1, o2) => o1.GetAutor().GetNombre().CompareTo(o2.GetAutor().GetNombre()));
            Console.WriteLine("Ordenado por autor");
            foreach (Obra obra in obras)
            {
                Console.WriteLine(obra);
            }
            Console.WriteLine();
            Array.Sort(obras);
            Console.WriteLine("Obras ordenadas por fecha");
            foreach (Obra obra in obras)
            {
                if(obra is Escultura)
                {
                    Console.WriteLine(obra);
                }
            }
            Console.WriteLine();
            Array.Sort(obras, (o1, o2) => o1.GetPropietario().CompareTo(o2.GetPropietario()));
            Console.WriteLine("Ordenador por propietario");
            foreach (Obra obra in obras)
            {
                
                Console.WriteLine(obra);
                
            }
        }
    }
}
