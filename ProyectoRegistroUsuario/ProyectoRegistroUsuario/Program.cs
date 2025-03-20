//Autor: Gabriel Hernández Collado
//Fecha: 20/3/2025
//Descripción: Tenemos una clase usuario con los datos: username y password. Al empezar el programa pedimos el usuario
//y la contraseña para poder continuar. Se comprobará en el fichero "users.txt" si ese usuario y contraseña son válidas.
//Cuando están validadas las credenciales se le irán pidiendo frases al usuario y se irán escribiendo al final del fichero
//"registro.txt" de esta forma: "username: texto escrito por el usuario - fecha y hora del momento"


namespace ProyectoRegistroUsuario
{
    internal class Program
    {
        public static bool ValidarUsuario(Usuario usuario)
        {
            string[] lineas = LeerFichero();
            if (usuario.GetUsername() == lineas[0] && usuario.GetPassword() == lineas[1])
            {
                return true;
            }
            return false;
        }

        public static string[] LeerFichero()
        {
            string[] lineas;
            try
            {
                lineas = File.ReadAllLines(@"..\..\..\users.txt");
                return lineas;
            }
            catch (IOException)
            {
                Console.WriteLine("Error al leer el archivo");
            }
            return null;
        }

        public static void EscribirLineas()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
