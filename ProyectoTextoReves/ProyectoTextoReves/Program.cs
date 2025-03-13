//Autor: Gabriel Hernández Collado
//Fecha: 13/3/2025
//Descripción: Crea un programa en C# que pida al usuario un nombre de fichero , y si existe,
//vuelque su contenido a otro fichero llamado "alreves.txt" y cuyas líneas deberán estar en el orden inverso al original.

//Por ejemplo

//    Hola

//    Soy yo

//El fichero de salida pondrá:

//    Soy yo
//    Hola

//Pista: Podemos usar una Pila o una Lista para guardar los datos de forma intermedia.

//Hazlo usando StreamReader y StreamWriter y otra vez usando ReadAllLines y WriteAllLines

namespace ProyectoTextoReves
{
    internal class Program
    {
        public static string PedirRutaFichero()
        {
            Console.Write("Introduce ruta del fichero: ");
            string entradaUsuario = Console.ReadLine();
            return entradaUsuario;
        }

        //public static void CambiarLineas()
        //{
        //    string rutaFichero = PedirRutaFichero();
        //    if (File.Exists(rutaFichero))
        //    {
        //        try
        //        { 
        //            string linea;
        //            StreamReader reader = new StreamReader(rutaFichero);   
        //            Stack<string> stack = new Stack<string>();
        //            while((linea = reader.ReadLine()) != null)
        //            {
        //                stack.Push(linea);
        //            }
        //            reader.Close();
        //            StreamWriter writer = new StreamWriter(rutaFichero);
        //            foreach (string l in stack)
        //            {
        //                writer.WriteLine(l);
        //            }
        //            writer.Close();
        //        }
        //        catch (IOException)
        //        {
        //            Console.WriteLine("Ha habido un problema al leer el archivo");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("El fichero no existe");
        //    }
        //}

        public static void CambiarLineas()
        {
            string rutaFichero = PedirRutaFichero();
            if (File.Exists(rutaFichero))
            {
                try
                {
                    string[] strings = File.ReadAllLines(rutaFichero);
                    Stack<string> stack = new Stack<string>();
                    foreach (string s in strings)
                    {
                        stack.Push(s);
                    }
                    File.WriteAllLines(rutaFichero, stack.ToArray());
                }
                catch (IOException)
                {
                    Console.WriteLine("Ha habido un problema al leer el archivo");
                }
            }
            else
            {
                Console.WriteLine("El fichero no existe");
            }
        }
        static void Main(string[] args)
        {
            CambiarLineas();
        }
    }
}
