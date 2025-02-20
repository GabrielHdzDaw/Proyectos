/* Autor: gabhercol
/* Fecha: 2/20/2025 11:21:26 AM
/* Descripción: 
*/
namespace ProyectoDiccionarioKlingon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Separa las frases por ". " para traducir varias frases
            Console.WriteLine(Diccionario.Traducir("Entiendo el honor. Éxito honorable, gracias. Casa y respeto. Entiendo al guerrero honorable klingon. Hoy es un buen día para morir."));
        }
    }
}
