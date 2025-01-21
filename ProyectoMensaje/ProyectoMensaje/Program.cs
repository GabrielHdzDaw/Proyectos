namespace ProyectoMensaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensaje mensaje = new Mensaje();
            Console.WriteLine(mensaje.GetFecha());
            mensaje.SetFecha("2/7/1993");
            Console.WriteLine(mensaje.GetFecha());
        }
    }
}
