namespace ProyectoMensaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensaje mensaje = new Mensaje();
            Console.WriteLine(mensaje.GetFecha());
            mensaje.SetFecha("11/7/1993");
            Console.WriteLine(mensaje);
        }
    }
}
