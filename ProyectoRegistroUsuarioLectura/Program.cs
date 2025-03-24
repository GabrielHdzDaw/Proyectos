/* Autor: gabri
/* Fecha: 20/03/2025 23:16:24
/* Descripción: Pide el nombre de usuario y contraseña de nuevo y saca por pantalla todas las estradas del usuario, sólo las suyas.
*/
namespace ProyectoRegistroUsuarioLectura
{
    internal class Program
    {
        public static bool ValidarUsuario(Usuario usuario)
        {
            bool validado = false;
            string[] lineas = LeerFichero(@"..\..\..\users.txt");
            foreach (string linea in lineas)
            {
                string[] strings = linea.Split(":");
                if (usuario.GetUsername() == strings[0] && usuario.GetPassword() == strings[1])
                {
                    validado = true;
                    Console.WriteLine("Usuario validado");
                }
            }
            return validado;
        }

        public static void MostrarEntradas(Usuario usuario)
        {
            string[] lineas = LeerFichero(@"..\..\..\registro.txt");
            bool encontrado = false;
            foreach (string linea in lineas)
            {
                string[] strings = linea.Split(":");
                if (usuario.GetUsername() == strings[0])
                {
                    Console.WriteLine(linea);
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("No se han encontrado entradas para este usuario");
            }
        }

        public static string[] LeerFichero(string ruta)
        {
            string[] lineas;
            try
            {
                lineas = File.ReadAllLines(ruta);

                return lineas;
            }
            catch (IOException)
            {
                Console.WriteLine("Error al leer el archivo");
            }
            return null;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduce nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();
            Console.Write("Introduce contraseña: ");
            string password = Console.ReadLine();
            Usuario usuario = new Usuario(nombreUsuario, password);
            if (ValidarUsuario(usuario))
            {
                MostrarEntradas(usuario);
            }
            else
            {
                Console.WriteLine("Usuario no validado");
            }
        }
    }
}
