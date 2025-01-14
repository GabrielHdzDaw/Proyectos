namespace ProyectoMoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto moto1 = new Moto("Honda", 3);
            Console.WriteLine(moto1);
            Moto moto2 = new Moto("Kawasaki",4);
            Console.WriteLine(moto1);
            Console.WriteLine(moto2);
        }
    }
}
