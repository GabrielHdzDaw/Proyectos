using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSerializacionXML
{
    [Serializable]
    public class VideojuegoConsola : Videojuego
    {
        string plataforma;
        public VideojuegoConsola() : base() { }
        public VideojuegoConsola(string titulo, string genero, double precio, string plataforma) : base(titulo, genero, precio)
        {
            this.plataforma = plataforma;
        }

        public string Plataforma { get => plataforma; set => plataforma = value; }

        public override string ToString()
        {
            return base.ToString() + " Plataforma: " + plataforma;
        }
    }
}
