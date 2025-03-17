//Autor: Gabriel Hernández Collado
//Fecha: 17/3/2025
//Descripción: Crea un programa en C# que muestre si es un fichero BMP y si está comprimido, leyendo toda la cabecera con una sola instrucción.
//La estructura de un fichero BMP es:

//INFORMACIÓN
//POSICIÓN EN EL FICHERO
//File type (letters BM)
//0-1
//File Size
//2-5
//Reserved
//6-7
//Reserved
//8-9
//Start of image data
//10-13
//Size of bitmap header
//14-17
//Width (pixels)
//18-21
//Height (pixels)
//22-25
//Number of planes
//26-27
//Size of each point
//28-29
//Compression (0=not compressed)
//30-33
//Image size
//34-37
//Horizontal resolution
//38-41
//Vertical resolution
//42-45
//Size of color table
//46-49
//Important colors counter
//50-53

namespace ProyectoBMP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\fichero.bmp";
            BinaryReader br = new BinaryReader(File.Open(filePath, FileMode.Open));
            char B = br.ReadChar();
            char M = br.ReadChar();
            Console.WriteLine(br.ReadInt32());
            if (B == 'B' && M == 'M')
            {
                br.BaseStream.Seek(30, SeekOrigin.Begin);
                int comprimido = br.ReadInt32();
                
                if(comprimido == 0)
                {
                    Console.WriteLine("El fichero es BMP y no está comprimido");
                }
                else
                {
                    Console.WriteLine("El fichero es BMP y está comprimido");
                }
            }
            else
            {
                Console.WriteLine("El fichero no es BMP");
            }
        }
    }
}
