//Autor: Gabriel Hernández Collado
//Fecha: 17/3/2025
//Descripción: Crea un programa que pida al usuario un nombre de fichero y compruebe si es un fichero PNG válido
//( bytes segundo, tercero y cuarto son P,N,G). Recuerda comprobar los errores.
//Hazlo utilizando BinaryReader por un lado y leyendo los 4 primeros bytes de golpe por otro lado (Método Read)


namespace ProyectoPNG
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");
            string entradaUsuario = Console.ReadLine();
            return entradaUsuario;
        }
        static void Main(string[] args)
        {
			string rutaFichero = PedirRutaFichero();
			try
			{
                
                BinaryReader br = new BinaryReader(File.Open(rutaFichero, FileMode.Open));
                br.BaseStream.Seek(1, SeekOrigin.Begin);
                char P = br.ReadChar();
                char N = br.ReadChar();
                char G = br.ReadChar();

                if (P == 'P' && N == 'N' && G == 'G')
                {
                    Console.WriteLine("El fichero es un PNG");
                }
                else
                {
                    Console.WriteLine("El fichero no es un PNG");
                }
                br.Close();

            }
			catch (IOException)
			{
                Console.WriteLine("Error al leer el fichero");
			}
        }
    }
}
