/* Autor: gabhercol
/* Fecha: 1/24/2025 12:23:18 PM
/* Descripción: Realiza una clase Mueble (abstracta) con los siguientes atributos:

anchura, altura, material.

Con sus Getters y Setters correspondientes y su método ToString que debe crear una cadena con  todos los datos separados por guiones en una sola línea.

Realiza también una clase Mesa que herede de Mueble que incluirá:

material de las patas 

con sus Getters y Setters correspondientes y su método ToString que debe llamar el método del Padre y añadir al final de la línea su atributo propio.

Una clase Mesa de escritorio que heredará de Mesa y que incluirá:

número de cajones

con sus Getters y Setters  correspondientes y su método ToString que debe llamar el método del Padre y añadir al final de la línea su atributo propio.


Otra clase Silla que también herede de Mueble y que incluirá:

ruedas (booleano)

Con sus Getters y Setters correspondientes y su método ToString que debe llamar el método del Padre y añadir al final de la línea su atributo propio.

En todas las clases se realizará su constructor y se reutilizará el código del padre en lo que se pueda.

Y un Main donde se creará un array de muebles de 6 posiciones donde las 2 primeras posiciones serán mesas, las 2 segundas sillas y las 2 últimas mesas de escritorio.

Rellena los datos de todos los elementos y Muestrálos al final.
*/
namespace ProyectoMuebles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mueble[] muebles = {
                new Mesa(100, 234, "madera pino", "madera alcornoque"),
                new Mesa(400, 350, "metal", "acero"),
                new Silla(50, 20, "madera pino", true),
                new Silla(35, 40, "madera abedul", false),
                new MesaEscritorio(320, 124, "madera fresno", "madera chopo", 4),
                new MesaEscritorio(410, 500, "plástico", "plástico", 2)
            };

            foreach (Mueble mueble in muebles)
            {
                Console.WriteLine(mueble);
            }
        }
    }
}
