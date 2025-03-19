/* Autor: gabri
/* Fecha: 19/03/2025 18:24:28
/* Descripción: Crea un visor hexadecimal (dump.exe), según los siguientes requisitos: recibirá un nombre de fichero 
como parámetro, y mostrará cada 16 bytes como secuencia de dos cifras en hexadecimal y luego como caracteres 
(los caracteres cuyo código ASCII sea inferior a 32 no se mostrarán, sino que en su lugar se mostrará un punto), como en el siguiente ejemplo:

00 00 00 00 64 00 00 00 28 00 00 00 28 00 00 00 ....d...(...(...

47 58 44 42 41 53 45 43 A0 0F 00 00 00 00 00 00 GXDBASEC........

00 00 00 00 00 00 00 00 FE FE 00 00 3C 00 00 00 ............<...

4E 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 N...............

00 00 00 00 4D 6F 75 73 65 00 00 00 00 00 00 00 ....Mouse.......

00 00 00 00 44 00 00 00 40 9F 40 67 6C 8B 43 96 ....D...@.@gl.C.

00 00                                           ..

(La última línea también se debe mostrar correctamente formateada, aunque contenga menos de 16 bytes, como se ve en el ejemplo).

Nota: se puede convertir un byte a hexadecimal con:

Convert.ToString(dato, 16);
*/
namespace ProyectoVisorHexadecimal
{
    internal class Program
    {
        public static byte[] LeerBytes(string fichero)
        {
            FileStream fs;
            try
            {
                if (File.Exists(fichero))
                {
                    fs = File.OpenRead(fichero);
                    byte[] bytes = new byte[fs.Length];
                    fs.Read(bytes, 0, bytes.Length);
                    fs.Close();
                    return bytes;
                }

            }
            catch (IOException)
            {
                Console.WriteLine("Ha habido un error al leer el archivo");
            }
            return null;
        }

        public static void MostrarHexadecimal(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i += 16)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (i + j < bytes.Length)
                    {
                        Console.Write(Convert.ToString(bytes[i + j], 16).PadLeft(2, '0') + " ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.Write(" ");
                for (int j = 0; j < 16; j++)
                {
                    if (i + j < bytes.Length)
                    {
                        if (bytes[i + j] < 32)
                        {
                            Console.Write(".");
                        }
                        else
                        {
                            Console.Write((char)bytes[i + j]);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            
            if (args.Length == 1)
            {
                byte[] bytes = LeerBytes(args[0]);
                if (bytes != null)
                {
                    MostrarHexadecimal(bytes);
                }
            }
            else
            {
                Console.WriteLine("Uso: <fichero>");
            }
        }
    }
}
