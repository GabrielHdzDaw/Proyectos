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
            bool validado = false;
            string[] lineas = LeerFichero();
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

        public static void EscribirLinea(string linea)
        {
            try
            {
                StreamWriter sw = File.AppendText(@"..\..\..\registro.txt");
                
                sw.WriteLine(linea + DateTime.Now);

                sw.Close();
                
            }
            catch (IOException)
            {
                Console.WriteLine("Error al escribir el archivo");
            }
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
                
                string entradaUsuario;
                do
                {
                    Console.Write("Introduce un texto ('fin' para terminar): ");
                    entradaUsuario = Console.ReadLine();
                    if (entradaUsuario != "fin")
                    {
                        EscribirLinea($"{usuario.GetUsername()}: {entradaUsuario} | {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
                    }
                    
                } while (entradaUsuario != "fin");
                
            }
            else
            {
                Console.WriteLine("Usuario no validado");
            }
        }
    }
}
