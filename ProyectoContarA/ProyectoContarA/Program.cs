//Autor: Gabriel Hernández Collado
//Fecha: 17/3/2025
//Descripción: Crea un programa que cuente las aes de un fichero binario. Debes usar FileStream y un bloque con el tamaño del fichero completo. 

namespace ProyectoContarA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaFichero = @"..\..\..\fichero.bmp";
            BinaryReader br;
            int contador = 0;
            try
            {
                FileStream fs = new FileStream(rutaFichero, FileMode.Open);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
                foreach (byte b in bytes)
                {
                    if (Convert.ToChar(b) == 'a' || Convert.ToChar(b) == 'A')
                    {
                        contador++;
                    }
                }
                Console.WriteLine(contador);
            }
            catch (IOException)
            {
                Console.WriteLine("Ha habido un problema al leer el fichero");
            }
            
           


        }
    }
}
