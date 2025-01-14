namespace ProyectoNumerosComplejos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroComplejo numero1 = new NumeroComplejo(3,5);
            NumeroComplejo numero2 = new NumeroComplejo(7,2);
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            //Console.WriteLine(numero1.GetMagnitud());
            Console.WriteLine(NumeroComplejo.Suma(numero1, numero2));
            NumeroComplejo suma = numero1 + numero2;
            Console.WriteLine(numero1 + numero2);
        }
    }
}
