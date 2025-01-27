/* Autor: gabhercol
/* Fecha: 1/27/2025 11:05:48 AM
/* Descripción: Crea una clase abstracta "Media", para guardar información de ficheros multimedia genéricos. 
Sus atributos son: autor, tamaño en KB, formato (por ejemplo MPEG4). Debe crear los getters y los setters de estos atributos. 
Crea también un constructor que asigna valor a los 3 atributos. Además tendrá un método abstracto llamado Play().

Crea una clase "Imagen" que herede de "Media" y añade los atributos: "anchura" (ej: 1600) y "altura", con sus correspondientes getters y setters,
así como su constructor. El método Play() mostrará "Imagen proyectando"

Crea una clase "Sonido", también hereda de "Media", con los atributos añadidos: "stereo" (booleano), "kbps" (ej 192), y "longitud" (en segundos),
crea también sus getters, setters y constructor. El método play mostrará "Sonido sonando"

Crea la clase "Video", también hereda de "Imagen", que tendrá como atributos propios "codec" (ej. H.264), y "longitud" (en segundos).
Crea también sus getters, setters y un constructor. El método Play() mostrará "Video Imagen proyectando"

Finalmente crea un clase "PruebaMedia" con un programa de prueba con un array con un tipo de cada. Muestra por pantalla sus datos.


*/
namespace ProyectoMediaNota
{
    internal class PruebaMedia
    {
        static void Main(string[] args)
        {
            Media[] media = {
                new Imagen("pepe", 256, "jpeg", 500, 700),
                new Sonido("jose", 340, "mp3", true, 320, 189),
                new Video("manu", 4534, "mov", 1920, 1080, "H.264", 600)
            };

            foreach (Media mediaFile in media)
            {
                Console.WriteLine(mediaFile);
                Console.WriteLine();
            }
        }
    }
}
