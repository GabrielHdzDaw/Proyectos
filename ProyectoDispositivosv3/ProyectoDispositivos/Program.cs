/* Autor: gabhercol
/* Fecha: 1/28/2025 12:05:10 PM
/* Descripción: Vamos a añadir a la clase Dispositivo el interfaz IComparable para poder ordenar por nombre alfabéticamente.
Además en el Main ordenaremos también por tamaño de la pantalla descendente.
Añadiremos al proyecto anterior (Dispositivos) un interfaz llamado ILocaliza que tendrá 2 métodos: ActivarGPS, DesactivarGPS
que sólo sacarán un texto del tipo (GPS del SmartPhone... activado  o GPS del SmartPhone desactivado). Los dispositivos táctiles 
serán los únicos que lo implementarán. Se creará un array (de tipo ILocaliza)en el main sólo con los elementos táctiles y se llamará a esos métodos. 
*/
namespace ProyectoDispositivosIComparableIComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILocaliza[] dispositivos =
            {
                new Smartphone("Samsung", 128, 6.5),
                new Tablet("Ipad", 141, 6.1),
                new Smartphone("Huawei", 788, 6.3),
            };

            foreach (ILocaliza dispositivo in dispositivos)
            {
                dispositivo.ActivarGPS();
                dispositivo.DesactivarGPS();
            }
        }
    }
}
