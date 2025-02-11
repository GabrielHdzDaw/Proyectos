/* Autor: gabhercol
/* Fecha: 2/11/2025 11:28:53 AM
/* Descripción: Vamos a realizar la gestión de una ListaDeLaCompra. Esta lista de la compra será un array de la 
clase Compra que consta de los siguientes datos: producto, urgencia de compra, fecha de la inclusión en la lista, adquirido sí o no.

Habra una serie de usuarios de los que guardaremos el nombre que podrán:

* Añadir producto

* Borrar producto

*Marcar como adquirido

*Consultar lista de la compra

De los productos guardaremos su nombre, y un array de establecimientos donde podemos comprarlos (Mercadona, consum, carnicería...)

Existirá por una parte un array de productos fijos que estableceremos en el código de los que podremos escoger para añadir a nuestra lista de la compra.(Clase ProductosDisponibles)

Cuando un usuario accede al sistema se le pide su usuario y contraseña (3 intentos) y se le pregunta la acción a realizar.

- Añadir producto --> se le muestran los ProductosDisponibles(método ToString) y elige aquel que quiere añadir y se le piden los demás datos. La fecha se establece a la actual (DateTime.Now)

- Borrar productos --> Se muestran todos y se borra el seleccionado

- Marcar como adquirido --> Atributo adquirido=sí.

- Consultar lista de la compra--> Método ToString de la clase ListaDeLaCompra.

Haz una clase con el menú para probarlo.

(Adjunto a esta entrega tenéis un png con el diagrama de clases)
*/
namespace ProyectoListaCompra
{
    internal class Program
    {
        public static bool ValidarUsuario(ListaUsuarios listaUsuarios)
        {
            int intentos = 3;
            bool valido = false;
            do
            {
                Console.Write("Introduce nombre de usuario: ");
                string nombre = Console.ReadLine();
                Console.Write("Introduce contraseña: ");
                string contrasena = Console.ReadLine();
                if (listaUsuarios.EsValido(nombre, contrasena))
                {
                    valido = true;
                }
                else
                {
                    intentos--;
                    Console.WriteLine($"Usuario o contraseña incorrectos. Te quedan {intentos} intentos.");
                }
            } while (intentos > 0 && !valido);
            return valido;
        }

        public static void MostrarProductosListaCompra(ListaCompra listaCompra)
        {
            int i = 0;
            foreach (Compra compra in listaCompra.GetCompras())
            {
                Console.WriteLine($"{i + 1}.{compra}");
            }
        }

        public static void MarcarComoAdquirido(ListaCompra listaCompra)
        {
            MostrarProductosListaCompra(listaCompra);
            Console.Write("Introduce el número del producto a adquirir: ");
            int index = Convert.ToInt32(Console.ReadLine());
            listaCompra.GetCompras()[index - 1].SetAdquirido(true);
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("1. Añadir producto");
            Console.WriteLine("2. Borrar producto");
            Console.WriteLine("3. Marcar como adquirido");
            Console.WriteLine("4. Consultar lista de la compra");
            Console.WriteLine("5. Salir");
            Console.Write("Introduce la opción deseada:");
        }

        public static void SwitchMenu(ListaCompra listaCompra)
        {
            MostrarMenu();
            
            int entradaUsuario = Convert.ToInt32(Console.ReadLine());
            switch (entradaUsuario)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    MarcarComoAdquirido(listaCompra);
                    break;
                case 4:
                    MostrarProductosListaCompra(listaCompra);
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            ListaUsuarios listaUsuarios = new ListaUsuarios();
            ListaCompra listaCompra = new ListaCompra();
            if (ValidarUsuario(listaUsuarios))
            {
                SwitchMenu(listaCompra);
            } else
            {
                Console.WriteLine("Usuario no validado. Saliendo del programa...");
            }
            
            
        }
    }
}
