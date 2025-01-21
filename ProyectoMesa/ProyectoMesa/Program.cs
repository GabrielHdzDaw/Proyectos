namespace ProyectoMesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesa mesa = new Mesa();
            Console.WriteLine(mesa);

            mesa.GetPata().SetColor("Blanco");
            mesa.GetPata().SetMaterial("Madera");
            Console.WriteLine(mesa);

            Pata pata = new Pata();
            pata.SetMaterial("cuero");
            pata.SetColor("rojo");
            mesa.SetPata(pata);

            Console.WriteLine(mesa);

            Mesita mesita = new Mesita();
            Console.WriteLine(mesita);
        }
    }
}
