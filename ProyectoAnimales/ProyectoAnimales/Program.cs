namespace ProyectoAnimales
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Animal[] perros = new Animal[3];
            for (int i = 0; i < perros.Length; i++)
            {
                perros[i] = new Perro("Toby" + i);
            }

            perros[2] = new PerroEnfadado("Satán");

            for (int i = 0; i < perros.Length; i++)
            {
                if (perros[i] is Perro)
                {
                    ((Perro)perros[i]).Ladrar();// Podemos castear el tipo
                }
                 
            }
        }
    }
}
