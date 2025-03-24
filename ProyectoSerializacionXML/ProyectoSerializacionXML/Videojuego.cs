using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            List<Videojuego> lista = new List<Videojuego> ();
            XmlSerializer formatter = new XmlSerializer(lista.GetType());
            FileStream fs = new FileStream(fichero, FileMode.Open,
                FileAccess.Read, FileShare.Read);
            lista = (List<Videojuego>)formatter.Deserialize(fs);
            fs.Close();
            return lista;
        }

        public static void GuardarVideojuegos(List<Videojuego> juegos, string fichero)
        {
            XmlSerializer formatter = new XmlSerializer(juegos.GetType());
            FileStream fs = new FileStream(fichero, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(fs, juegos);
            fs.Close();
        }

        public override string ToString()
        {
            return $"Título: {titulo}, Género: {genero}, Precio: {precio}";
        }
    }
}
