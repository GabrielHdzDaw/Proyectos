//Autor: Gabriel Hernández Collado
//Fecha: 25/3/2025
//Descripción: Lo mismo que el anterior pero leyendo de archivo.


namespace ProyectoHotelFichero
{
    internal class Program
    {
        public static List<Hotel> LeerFichero()
        {
            List<Hotel> hoteles = new List<Hotel>();
            string fichero = @"..\..\..\hoteles.txt";
            string[] lineas = File.ReadAllLines(fichero);
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(';');
                
                hoteles.Add(new Hotel(campos[1], campos[0], Convert.ToInt32(campos[2])));
                
            }
            return hoteles;
        }
        static void Main(string[] args)
        {
            List<Hotel> hoteles = LeerFichero();
            Console.WriteLine("Listado de hoteles ordenado de más a menos rating:");
            //hoteles.OrderByDescending(h => h.Estrellas).ToList().ForEach(h => Console.WriteLine(h));
            hoteles.Sort((h1, h2) => h2.Estrellas.CompareTo(h1.Estrellas));
            hoteles.ForEach(h => Console.WriteLine("\t" + h));
            Console.WriteLine();
            Console.WriteLine("Hoteles de más de 3 estrellas:");
            hoteles.Where(h => h.Estrellas > 3).ToList().ForEach(h => Console.WriteLine("\t" + h));
            Console.WriteLine();
            Console.WriteLine("Media de estrellas de los hoteles de Alicante:");
            Console.WriteLine("\t" + hoteles.Where(h => h.Localidad == "Alicante").Average(h => h.Estrellas));
        }
    }
}
