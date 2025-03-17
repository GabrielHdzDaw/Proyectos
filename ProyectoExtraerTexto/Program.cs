/* Autor: gabri
/* Fecha: 17/03/2025 16:44:34
/* Descripción: Crea un programa que extraiga el texto imprimible (ASCII 32-126, 10 y 13) de 
un fichero binario y lo escribirá en un fichero de texto. Siempre comprobando errores.
*/
namespace ProyectoExtraerTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"..\..\..\fichero.bmp";
			try
			{
                FileStream fs = new FileStream(ruta, FileMode.Open);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
                foreach (byte b in bytes)
                {
                    if ((b >= 32 && b <= 126) || b == 10 || b == 13)
                    {
                        Console.Write((char)b);
                    }
                }


            }
			catch (IOException)
			{
                Console.WriteLine("Error al leer el fichero");
            }
        }
    }
}
