/* Autor: gabri
/* Fecha: 26/01/2025 20:13:14
/* Descripción: 
(6.8.1) Crea un único fuente que contenga las siguientes clases:
• Una clase Trabajador, cuyo constructor escriba en pantalla "Soy un
trabajador".
• Una clase Programador, que derive de Trabajador, cuyo constructor escriba
en pantalla "Soy programador".
• Una clase Analista, que derive de Trabajador, cuyo constructor escriba en
pantalla "Soy analista".
• Una clase Ingeniero, que derive de Trabajador, cuyo constructor escriba en
pantalla "Soy ingeniero".
• Una clase IngenieroInformatico, que derive de Ingeniero, cuyo constructor
escriba en pantalla "Soy ingeniero informático".
• Una clase "PruebaDeTrabajadores", que cree un objeto perteneciente a
cada una de esas clases
*/
namespace ProyectoOficios
{
    internal class PruebaDeTrabajadores
    {
        static void Main(string[] args)
        {
            Trabajador trabajador = new Trabajador();
            Programador programador = new Programador();
            Analista analista = new Analista();
            Ingeniero ingeniero = new Ingeniero();
            IngenieroInformatico ingenieroInformatico = new IngenieroInformatico();
        }
    }
}
