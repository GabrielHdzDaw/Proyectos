//Autor: Gabriel Hernández Collado
//Fecha: 14/3/2025
//Descripción: Crea un conversor de texto a HTML que lea un fichero de texto y cree un HTML con su contenido.
//El nombre de fichero se introducirá como parámetro en la línea de comandos. Si no estuviera ese parámetro se pedirá dentro del programa.

//Por ejemplo:  conversor texto.txt

//Hola
//Soy yo
//Ya he terminado

//El resultado será (texto.html)

//<html>
//<body>
//<p>Hola</p>
//<p>Soy yo</p>
//<p>Ya he terminado</p>
//</body>
//</html>

//El nombre del fichero destino debe ser el mismo que el original pero sustituyendo .txt si existe por .html.
//Si el fichero original no tiene extensión simplemente se le añade el .html.
//Se deben comprobar los errores de manera adecuada.


namespace ProyectoConversorHTML
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");

            return Console.ReadLine();
        }

        public static void Convertir(string fichero)
        {
            
            if (File.Exists(fichero))
            {
                try
                {
                    List<string> lista = new List<string>(File.ReadAllLines(fichero));
                    StreamWriter sw = new StreamWriter(fichero.Replace(".txt", ".html"));
                    sw.WriteLine("<html>");
                    sw.WriteLine("<body>");
                    foreach (string linea in lista)
                    {
                        sw.WriteLine($"<p>{linea}</p>");
                    }
                    sw.WriteLine("</body>");
                    sw.WriteLine("</html>");
                    sw.Close();
                }
                catch (IOException)
                {
                    Console.WriteLine("Ha habido un problema al leer el archivo");
                }
            }
        }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                string fichero = PedirRutaFichero();
                Convertir(fichero);
            }
            else if (args.Length == 1)
            {
                string fichero = args[0];
                Convertir(fichero);
            }
        }
    }
}
