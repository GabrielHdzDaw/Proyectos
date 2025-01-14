namespace ConsolAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Titulo titulo1 = new Titulo();
            Titulo titulo2 = new Titulo("Filigranas");
            //titulo1.Mostrar();
            //titulo2.Mostrar();
            //titulo3.Mostrar();

            TituloSubrayado otroTitulo = new TituloSubrayado();
            TituloCentrado tituloCentrado = new TituloCentrado();
            tituloCentrado.Mostrar();
        }
    }
}