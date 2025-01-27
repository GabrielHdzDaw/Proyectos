/* Autor: gabhercol
/* Fecha: 1/27/2025 12:30:36 PM
/* Descripción: Crea un interface IMedible  con un método GetTamanyo() y otro interface IDibujable con el método
Dibujar() y una clase abstracta FiguraG con los datos x1,y1 (esquina superior izquierda) x2,y2 (esquina inferior derecha).
De esta clase abstracta deberá heredar la clase Cuadrado y Triángulo que implementarán también los 2 interfaces. La clase
FiguraG deberá tener un constructor que reciba todos los datos y uno vacío que reutilizará el código del anterior, además 
del método Mostrar abstracto que muestre si es Triágulo o Cuadrado y cual es su tamaño.
Crea una clase para probarlo
*/
namespace ProyectoInterfazFiguras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FiguraG triangulo = new Triangulo(10, 25, 20, 35);
            FiguraG cuadrado = new Cuadrado(1, 10, 2, 15);

            ((IDibujable)triangulo).Dibujar();
            //((IDibujable)cuadrado).Dibujar();
        }
    }
}
