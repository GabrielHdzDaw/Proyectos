/* Autor: gabhercol
/* Fecha: 2/18/2025 11:31:55 AM
/* Descripción:Realizaremos una clase llamada Ahorcado y que nos permitirá jugar al ahorcado.

Esta clase tendrá una lista de palabras que puedan salir para el juego y un entero que será la palabra con 
la que estamos jugando ahora mismo y un string con el estado de la palabra (--A--) o (H-LA). O sea como está 
ahora mismo la palabra de destapada. Y un entero con el estado del ahorcado. El getter de esta dato deberá 
devolver un string indicando: cabeza, cuerpo, brazo, brazos... en función del estado. Y en vez de setter habrá 
un método AddDaño que le sumará 1 al estado del ahorcado.

Deberá tener también un método Add(string) para añadir nuevas palabras a la lista.

El método jugar() generará un número aleatorio entre 0 y el número de palabras que hay en Lista (Count). Esa será 
la palabra con la que se va a Jugar. Después se llamará al método DibujaPalabra() que dibuja el estado de la palabra 
actual y a otro método DibujaAhorcado() que dibujará el muñequito en función de como vamos. Después de esto se pide 
una letra al usuario y se llama al método ActualizaPalabra() que como su nombre indica actualiza el estado de la palabra 
y al método ActualizaAhorcado(). Esto se realizará mientras no ganemos (método bool HasGanado() que comprueba el estado
de la palabra para ver si hemos ganado)  o nos ahorquemos (método EstasAhorcado() que comprueba si no nos quedan oportunidades). 
*/
namespace ProyectoAhorcado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = { "hola", "adios", "casa", "coche", "perro", "gato", "raton", "elefante", "caballo", "pajaro" };
            List<string> listaPalabras = palabras.ToList();

            Ahorcado ahorcado = new Ahorcado(listaPalabras);

            ahorcado.Jugar();
        }
    }
}
