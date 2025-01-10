namespace ConsolAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Titulo titulo1 = new Titulo();
            Titulo titulo2 = new Titulo("Filigranas");
            Titulo titulo3 = new Titulo("Filigranas", Console.WindowWidth / 2, Console.WindowHeight / 2);
            //titulo1.Mostrar();
            //titulo2.Mostrar();
            //titulo3.Mostrar();

            TituloSubrayado otroTitulo = new TituloSubrayado();
            otroTitulo.Mostrar();
        }
    }
}