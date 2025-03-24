using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProyectoSerializacionXML
{
    [XmlInclude(typeof(VideojuegoPC))]
    [XmlInclude(typeof(VideojuegoConsola))]
    [Serializable]
    public class Videojuego
    {
        protected string titulo;
        protected string genero;
        protected double precio;

        public Videojuego()
        {
        }

        public Videojuego(string titulo, string genero, double precio)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.precio = precio;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Genero { get => genero; set => genero = value; }
        public double Precio { get => precio; set => precio = value; }

        public static List<Videojuego> CargarVideojuegos(string fichero)
        {
            string jsonString = null;
            try
            {
                jsonString = File.ReadAllText(fichero);
            }
            catch (IOException)
            {
                Console.WriteLine("No se ha podido leer el archivo");
            }
            return JsonSerializer.Deserialize<List<Videojuego>>(jsonString);
        }

        public static void GuardarVideojuegos(List<Videojuego> juegos, string fichero)
        {
            string json = null;
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            json = JsonSerializer.Serialize(juegos, opciones);
            try
            {
                File.WriteAllText(fichero, json);
            }
            catch (IOException)
            {
                Console.WriteLine("");
            }
        }

        public override string ToString()
        {
            return $"Título: {titulo}, Género: {genero}, Precio: {precio}";
        }
    }
}
