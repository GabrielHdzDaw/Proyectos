/* Autor: gabhercol
/* Fecha: 2/14/2025 12:41:01 PM
/* Descripción: 
*/
namespace ProyectoListaStrings
{
    internal class Program
    {
        public static void RellenarLista(List<string> lista)
        {
            Console.Write("Introduce números: ");
            string entradaUsuario = "a";

            while (!entradaUsuario)
            {

                lista.Add(entradaUsuario);
            }
        }

        public static void MostrarListaInversa(List<int> lista)
        {
            Console.WriteLine("Recorriendo lista: ");
            for (int i = lista.Count - 1; i > 0; i--)
            {
                Console.WriteLine(lista[i]);
            }
        }

        public static void ComprobarNumero(List<int> lista)
        {
            Console.WriteLine("Introduce número a buscar: ");
            int numero;
            if (Int32.TryParse(Console.ReadLine(), out numero))
            {
                if (lista.IndexOf(numero) > -1)
                {
                    Console.WriteLine($"{numero} está en la posición {lista.IndexOf(numero)}");
                }
                else
                {
                    Console.WriteLine($"{numero} no está");
                }
            }
        }

        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            RellenarLista(numeros);
            MostrarListaInversa(numeros);
            ComprobarNumero(numeros);
        }
    }
}
