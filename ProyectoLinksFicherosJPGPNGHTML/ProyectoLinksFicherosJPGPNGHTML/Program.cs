//Autor: Gabriel Hernández Collado
//Fecha: 28/3/2025
//Descripción: Crea un programa para crear un fichero HTML que contenga la lista de imagenes (PNG y JPG) en el directorio actual.
//Por ejemplo:

//1.png
//2.jpg

//el resultado debe ser


//<html>
//<body>
//<ul>
//<li><a href="1.png">1.png</a></li>
//<li><a href="2.jpg">2.jpg</a></li>
//</ul>
//</body>
//</html>

namespace ProyectoLinksFicherosJPGPNGHTML
{
    internal class Program
    {
        public static string[] ObtenerImagenes()
        {
            string[] archivos = Directory.GetFiles(".", "*.PNG");
            string[] archivos2 = Directory.GetFiles(".", "*.JPG");
            string[] archivos3 = new string[archivos.Length + archivos2.Length];
            archivos.CopyTo(archivos3, 0);
            archivos2.CopyTo(archivos3, archivos.Length);
            return archivos3;
        }

        public static void EscribirHTML(string[] archivos)
        {
            StreamWriter sw = new StreamWriter("index.html");
            sw.WriteLine("<html>");
            sw.WriteLine("<body>");
            sw.WriteLine("<ul>");
            foreach (string archivo in archivos)
            {
                sw.WriteLine($"<li><a href=\"{archivo}\">{archivo}</a></li>");
            }
            sw.WriteLine("</ul>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();
        }
        static void Main(string[] args)
        {
            EscribirHTML(ObtenerImagenes());
        }
    }
}

