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
            Perro perro = new Perro("Bobby");
            Pato pato = new Pato("José Luis");
            perro.Hablar();
            pato.Hablar();
        }
    }
}
