/* Autor: gabhercol
/* Fecha: 2/14/2025 12:19:20 PM
/* Descripción: Introduce un número indeterminado de enteros en una Lista de enteros (hasta que el usuario pulse enter).
Luego muéstralos por pantalla en orden Inverso.
Luego se pedirá al usuario un número y debes sacar por pantalla la posición que ocupa ese número.

*/
namespace ProyectoListaEnteros
{
    internal class Program
    {
        public static void RellenarLista(List<int> lista)
        {
            Console.Write("Introduce números: ");
            int entradaUsuario;

            while (Int32.TryParse(Console.ReadLine(), out entradaUsuario))
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
                if(lista.IndexOf(numero) > -1)
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
