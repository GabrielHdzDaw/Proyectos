/* Autor: gabhercol
/* Fecha: 2/14/2025 11:14:38 AM
/* Descripción: 
*/

using System.Collections.Generic;
namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            int count = stack.Count;
            int number = stack.Peek();
            Console.WriteLine(number);
            Console.WriteLine(count);
        }
    }
}
