/* Autor: gabri
/* Fecha: 28/01/2025 20:07:25
/* Descripción: Vamos a guardar información sobre obras de arte (clase abstracta), de cada obra guardaremos su autor y su propietario
(muchas obras de arte de los museos están en exhibiciones temporales) . Además del nombre y el año en el que fue creado.
Tendremos sólo 2 tipos de obras de arte: pinturas y esculturas.De las esculturas guardaremos el material en el que están hechas.
De los autores guardaremos el nombre.
Haz una clase de prueba que tenga un menú que nos permita muestrar la información de las obras y las ordene por el año y cuando 
el año sea igual por el nombre. (implementa IComparable.)
*/
namespace ProyectoMuseo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obra[] obras = { 
                new Pintura("Leonardo Da Vinci", "Museo del Louvre", "La Gioconda", 1503),
                new Escultura("Miguel Ángel", "Museo del Vaticano", "David", 1504, "Mármol"),
                new Pintura("Vincent Van Gogh", "Museo Van Gogh", "Los Girasoles", 1888),
                new Escultura("Auguste Rodin", "Museo Rodin", "El Pensador", 1902, "Bronce"),
                new Pintura("Pablo Picasso", "Museo Picasso", "Guernica", 1937),
                new Escultura("Henry Moore", "Museo Henry Moore", "Reclining Figure", 1951, "Bronce")
            };

            Array.Sort(obras);

            foreach (Obra obra in obras)
            {
                Console.WriteLine(obra);
            }
        }
    }
}
