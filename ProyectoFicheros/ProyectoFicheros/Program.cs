/* Autor: gabhercol
/* Fecha: 3/10/2025 11:20:21 AM
/* Descripción: Manejo de ficheros 
*/
namespace ProyectoFicheros
{
    internal class Program
    {
        public static void Ejercicio1()
        {
            StreamWriter myFile = File.CreateText("../../../textFile1.txt");
            myFile.WriteLine("Hola");
            myFile.WriteLine("Adiós");
            myFile.Close();
        }
        public static void Ejercicio2()
        {
            using (StreamWriter myFile = File.AppendText("../../../textFile2.txt"))
            {
                for (int i = 101; i <= 200; i++)
                {
                    myFile.WriteLine($"Línea {i}", true);
                }
            }
        }

        public static bool EsPrimo(int num)
        {
            bool primo = true;
            for (int i = 2; i < num && num % i == 0; i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                }
            }
            return primo;
        }

        public static void Ejercicio3()
        {
            using (StreamWriter myFile = new StreamWriter("../../../primos.txt"))
            {
                int i = 2;
                int contador = 0;
                while (contador < 50)
                {
                    if (EsPrimo(i))
                    {
                        myFile.Write(i + " ");
                        contador++;
                    }
                    i++;
                }
            }
        }

        public static void Ejercicio4()
        {
            StreamReader myFile = new StreamReader("../../../primos.txt");
            Console.WriteLine(myFile.ReadLine());
            myFile.Close();
        }

        public static void Ejercicio5()
        {

            Console.Write("Introduce el nombre de un fichero: ");
            string nombreFichero = Console.ReadLine();
            StreamReader myFile = new StreamReader($"{nombreFichero}");
            string line = myFile.ReadLine();
            do
            {
                
                if (line != null)
                {
                    Console.WriteLine(line);
                    line = myFile.ReadLine();
                }

            } while (line != null);
            myFile.Close();
        }
        public static void Main(string[] args)
        {
            //Ejercicio1();
            Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5(); 
        }
    }
}
