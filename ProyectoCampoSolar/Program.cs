/* Autor: gabri
/* Fecha: 03/02/2025 14:47:42
/* Descripción: Vamos a crear el panel de control de un campo solar que consta de los siguientes elementos:

-- Placas solares

-- Motores

--Distribuidores

-- Baterías

--Sensores

Todos los elementos tienen un nombre y un estado (encedido o apagado)

Las placas solares pueden girarse un número determinado de grados para obtener la máxima luz solar en cada momento.
Tendrán un atributo propio correspondiente a los grados en los que se encuentra en cada momento.

Los motores se podrán girar también un número determinado de grados (con lo que deberán tener el
atributo grados también) además de poder encenderse y apagarse.

Los distribuidores sólo se podrán encender o apagar.

Las baterías sólo podrán encenderse y apagarse.

Y los sensores los consideraremos un subtipo de placa solar pero que también pueden encenderse y apagarse.

Los métodos encender o apagar sólo cambiarán el estado del elemento a encendido o apagado.
*/
namespace ProyectoCampoSolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Elemento[] elementos = 
            {
                new Sensor("Sensor1", 30),
                new PlacaSolar("PlacaSolar1", 45),
                new Motor("Motor1", 90),
                new Distribuidor("Distribuidor1"),
                new Bateria("Bateria1")
            };

            
            foreach (Elemento elemento in elementos)
            {
                
                Console.WriteLine(elemento.ToString());
                elemento.Encender();
                if (elemento is PlacaSolar)
                {
                    ((PlacaSolar)elemento).Girar(90);
                } else if (elemento is Motor)
                {
                    ((Motor)elemento).Girar(90);
                } else if (elemento is Sensor)
                {
                    ((Sensor)elemento).Girar(90);
                } 
                
            }
            Console.WriteLine();
            foreach (Elemento elemento in elementos)
            {
                Console.WriteLine(elemento.ToString());
                
            }
        }
    }
}
