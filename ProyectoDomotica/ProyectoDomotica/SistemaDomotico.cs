/* Autor: gabhercol
/* Fecha: 2/4/2025 11:13:44 AM
/* Descripción: 
*/
namespace ProyectoDomotica
{
    internal class SistemaDomotico
    {
        static void Main(string[] args)
        {
            Persiana persiana1 = new Persiana("Persiana 1", 0);
            Persiana persiana2 = new Persiana("Persiana 2", 0);
            Persiana persiana3 = new Persiana("Persiana 3", 0);
            Dispositivo[] dispositivos =
            {
                new Ventana("Ventana 1", persiana1),
                new Ventana("Ventana 2", persiana2),
                new Ventana("Ventana 3", persiana3),
                new Puerta("Puerta 1", false),
                new PuertaGaraje("Puerta garaje 1", false, 0),
                new Luz("Luz 1", false),
                new Calefaccion("Calefaccion 1", false, 25),
                new Calefaccion("Calefaccion 2", false, 23),
            };

            foreach (Dispositivo dispositivo in dispositivos)
            {
                Console.WriteLine(dispositivo);
            }

            foreach (Dispositivo dispositivo in dispositivos)
            {
                if (dispositivo is Puerta)
                {
                    if (((Puerta)dispositivo).GetBloqueado())
                    {
                        ((Puerta)dispositivo).Desbloquear();
                    }
                    else
                    {
                        ((Puerta)dispositivo).Bloquear();
                    }
                }
                if(dispositivo is IEncendible)
                {
                    ((IEncendible)dispositivo).CambiarEstado();
                }
                if (dispositivo is PuertaGaraje)
                {
                    if (((PuertaGaraje)dispositivo).GetApertura() >= 50)
                    {
                        ((PuertaGaraje)dispositivo).Bajar();
                    }
                    else
                    {
                        ((PuertaGaraje)dispositivo).Subir();
                    }
                }
                if(dispositivo is ITemperatura)
                {
                    ((ITemperatura)dispositivo).CambiarTemperatura(20);
                }
                if (dispositivo is Ventana)
                {
                    ((Ventana)dispositivo).Abrir(25);
                }
            }


            Console.WriteLine();
            foreach (Dispositivo dispositivo in dispositivos)
            {
                Console.WriteLine(dispositivo);
            }
        }
    }
}
