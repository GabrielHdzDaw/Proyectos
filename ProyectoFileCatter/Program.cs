/* Autor: gabri
/* Fecha: 18/03/2025 22:07:47
/* Descripción:  Vamos a realizar el comando contrario al splitter realizado anteriormente. Se escribirá en consola:
catter ejemplo.bmp
Y unirá todos los ficheros que encuentre en uno solo concatenandolos en el orden adecuado (001, 002...)
Se creará un fichero llamado ejemplo.bmp como resultado. Si este fichero ya existe se pregunta si se desea sobreescribir 
y si se dice que no se crea un fichero llamado ejemplo.bmp.bak
*/
namespace ProyectoFileCatter
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
                    Console.WriteLine(fs.Length);
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

        public static void EscribirBytes(string fichero, byte[] bytes)
        {
            FileStream fs;
            try
            {
                fs = new FileStream(fichero, FileMode.Append);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Ha habido un error al escribir el archivo");
            }
        }

        public static void Catter(string fichero)
        {
            int i = 1;
            if (File.Exists(fichero + ".bmp"))
            {
                Console.WriteLine("El fichero ya existe, desea sobreescribirlo? (s/n)");
                string respuesta = Console.ReadLine();
                if (respuesta == "n")
                {
                    File.Create(fichero + ".bak");
                }
            }
            while (File.Exists(fichero + "." + (i).ToString("000")))
            {
                Console.WriteLine($"Leyendo bytes del fichero {i}");
                byte[] bytes = LeerBytes(fichero + "." + i.ToString("000"));
                Console.WriteLine($"Escribiendo bytes del fichero {i}");
                EscribirBytes(fichero, bytes);
                i++;
            }
        }

        public static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                Catter(args[0]);
            }
            else
            {
                Console.WriteLine("Uso: catter <fichero>");
            }
        }
         
      
    }
}
