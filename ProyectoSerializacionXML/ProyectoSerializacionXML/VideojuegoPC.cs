using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSerializacionXML
{
    [Serializable]
    public class VideojuegoPC: Videojuego
    {
        string tipo;
        public VideojuegoPC() : base() { }
        public VideojuegoPC(string titulo, string genero, double precio, string tipo) : base(titulo, genero, precio) 
        {
            this.tipo = tipo;
        }

        public string Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return base.ToString() + " " + tipo;
        }
    }

}
