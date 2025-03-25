//Autor: Gabriel Hernández Collado
//Fecha: 25/3/2025
//Descripción: Crea un programa llamado Ejercicio_10a_02 que defina una clase Receta que almacene datos de recetas de cocina:
//nombre, categoría (carnes, pastas...) y calorías. Dada una lista de recetas rellenada a mano, obtén:

//Recetas de menos de 500 calorías
//    Nombres de las recetas de "carnes", ordenadas alfabéticamente
//    Media de calorías de las recetas de "verduras"

namespace ProyectoReceta
{
    internal class Program
    {
        public static List<Receta> RellenarLista()
        {
            List<Receta> recetas = new List<Receta>();
            recetas.Add(new Receta("Tortilla de patatas", "Entrante", 500));
            recetas.Add(new Receta("Paella", "Principal", 800));
            recetas.Add(new Receta("Bistec", "Carne", 600));
            recetas.Add(new Receta("Tarta de queso", "Postre", 300));
            recetas.Add(new Receta("Menestra", "Verdura", 200));
            recetas.Add(new Receta("Chuletón", "Carne", 600));
            recetas.Add(new Receta("Lentejas", "Legumbre", 600));
            recetas.Add(new Receta("Ensalada", "Verdura", 200));
            recetas.Add(new Receta("Berenjenas rellenas", "Verdura", 200));
            recetas.Add(new Receta("Chuletas de pollo", "Carne", 600));
            return recetas;
        }
        static void Main(string[] args)
        {
            
            List<Receta> recetas = RellenarLista();
            Console.WriteLine("Recetas de menos de 500 calorías: ");
            recetas.Where(r => r.GetCalorias() < 500)
                .ToList().
                ForEach(r => Console.WriteLine("    " + r));
            Console.WriteLine();
            Console.WriteLine("Recetas de carne ordenadas alfabéticamente: ");
            recetas.Where(r => r.GetCategoria() == "Carne")
                .OrderBy(r => r.GetNombre())
                .ToList()
                .ForEach(r => Console.WriteLine("    " + r));
            Console.WriteLine();
            Console.WriteLine("Media de calorías de las recetas de verduras: ");
            Console.WriteLine("    " + recetas.Where(r => r.GetCategoria() == "Verdura").Average(r => r.GetCalorias()));
            Console.WriteLine();
            Console.WriteLine("Cuántas recetas de más de 800 calorías: ");
            Console.WriteLine("    " + recetas.Count(r => r.GetCalorias() > 800));




        }
    }
}
