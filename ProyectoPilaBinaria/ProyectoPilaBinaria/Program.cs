/* Autor: gabhercol
/* Fecha: 2/14/2025 11:26:28 AM
/* Descripción: Crea un proyecto que calcule la conversión de un número decimal a binario, empleando una pila. Los pasos a seguir son:

    Le pediremos al usuario que escriba un número entero en formato decimal
    Crearemos una pila para almacenar números enteros
    En un bucle, iremos dividiendo sucesivamente el número del usuario entre 2, almacenando en la pila el resto de la división.
    Finalmente, recorreremos la pila mostrando cada dígito almacenado (todo serán 0 o 1), y ese será el equivalente en binario del número introducido por el usuario

Aquí tenéis un ejemplo de uso:

Dime un número en formato decimal:
46

/* Esto sería el proceso interno del algoritmo, que no tiene que salir por pantalla 
46 / 2 = 23 y sobra 0 -> almacenamos 0 en la pila
23 / 2 = 11 y sobra 1 -> almacenamos 1 en la pila
11 / 2 = 5 y sobra 1 -> almacenamos 1 en la pila
5 / 2 = 2 y sobra 1 -> almacenamos 1 en la pila
2 / 2 = 1 y sobra 0 -> almacenamos 0 en la pila

1/2 =0 y sobra 1 -> almacenamos 1 en la pila

/* Fin del algoritmo interno 

El número en binario es:
101110
*/
namespace ProyectoPilaBinaria
{
    internal class Program
    {
        public static Stack<int> RellenarStack(int numero)
        {
            int resultado = 0;
            Stack<int> stack = new Stack<int>();
            while(numero != 0)
            {
                resultado = numero % 2;
                stack.Push(resultado);
                numero /= 2;
            }
            return stack;

        }

        public static string ConvertirACadena(Stack<int> stack)
        {
            string binario = "";
            while(stack.Count > 0)
            {
                binario += stack.Pop();
            }
            return binario;
        }

        public static string ConvertirABinario(int numero)
        {
            Stack<int> stack = RellenarStack(numero);
            return ConvertirACadena(stack);
        }
        static void Main(string[] args)
        {
            Console.Write("Introduce un número en base 10: ");
            int numero;
            if(Int32.TryParse(Console.ReadLine(), out numero))
            Console.WriteLine(ConvertirABinario(numero));
        }
    }
}
