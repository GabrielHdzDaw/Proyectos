namespace ProyectoPersona
{
    internal class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Lentejas", 145, "Wisconsin");
            Persona persona2 = new Persona("Patatas");
            Persona persona3 = new Persona();

            
            persona2.SetNombre("Matilde");

            Console.WriteLine(persona1.ToString()); 
            Console.WriteLine(persona2.ToString()); 
            Console.WriteLine(persona3.ToString());
        }
    }
}
