using System.Text.Json;

namespace Test
{
    
    internal class Program
    {
        public static string Serializar(List<Persona> lista)
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return JsonSerializer.Serialize(lista, opciones);
        }

        public static List<Persona> Deserializar(string json)
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var lista = JsonSerializer.Deserialize<List<Persona>>(json, opciones);
            foreach (var persona in lista)
            {
                Console.WriteLine(persona);
            }
            return lista;
        }
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("Juan", "Perez", 30));
            personas.Add(new Persona("Maria", "Gomez", 25));
            personas.Add(new Persona("Carlos", "Lopez", 40));
            personas.Add(new Persona("Ana", "Diaz", 35));

            string json = Serializar(personas);

            Console.WriteLine(json);
        }
    }
}
