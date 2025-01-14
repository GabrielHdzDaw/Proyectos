namespace ProyectoVentanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            Ventana[] ventanas = new Ventana[10];
            for (int i = 0; i < ventanas.Length; i++)
            {
                ventanas[i] = new Ventana(generator.Next(90, 121), generator.Next(40, 101));
            }

            foreach (Ventana ventana in ventanas)
            {
                ventana.Mostrar();
            }
        }
    }
}
