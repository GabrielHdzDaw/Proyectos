//Autor: Gabriel Hernández Collado
//Fecha: 25/3/2025
//Descripción: Crea un programa llamado Ejercicio_10a_03 con una clase Hotel que almacene datos de hoteles:
//nombre, localidad y estrellas (de 1 a 5). Crea una lista de hoteles y obtén:

//Listado de hoteles ordenado de más a menos rating usando una expresión lambda
//    Hoteles de más de 3 estrellas usando LINQ
//    Media de estrellas de los hoteles de Alicante



namespace ProyectoHoteles
{
    internal class Program
    {
        public static List<Hotel> RellenarLista()
        {
            List<Hotel> hoteles = new List<Hotel>
            {
                new Hotel("Oasis Palace", "Alicante", 5),
                new Hotel("Riviera Sunset", "Miami", 4),
                new Hotel("Alpino Lodge", "Zúrich", 3),
                new Hotel("Desert Mirage", "Alicante", 5),
                new Hotel("Aurora Heights", "Toronto", 4),
                new Hotel("Lago Esmeralda", "Ginebra", 3),
                new Hotel("Costa Dorada Inn", "Alicante", 4),
                new Hotel("Neon Lights Hotel", "Las Vegas", 5),
                new Hotel("Selva Encantada", "Manaos", 3),
                new Hotel("Royal Heritage", "Londres", 5)
            };
            return hoteles;
        }
        static void Main(string[] args)
        {
            List<Hotel> hoteles = RellenarLista();
            Console.WriteLine("Listado de hoteles ordenado de más a menos rating:");
            //hoteles.OrderByDescending(h => h.Estrellas).ToList().ForEach(h => Console.WriteLine(h));
            hoteles.Sort((h1, h2) => h2.Estrellas.CompareTo(h1.Estrellas));
            hoteles.ForEach(h => Console.WriteLine("    " + h));
            Console.WriteLine();
            Console.WriteLine("Hoteles de más de 3 estrellas:");
            hoteles.Where(h => h.Estrellas > 3).ToList().ForEach(h => Console.WriteLine("    " + h));
            Console.WriteLine();
            Console.WriteLine("Media de estrellas de los hoteles de Alicante:");
            Console.WriteLine("    " + hoteles.Where(h => h.Localidad == "Alicante").Average(h => h.Estrellas));
        }
    }
}
