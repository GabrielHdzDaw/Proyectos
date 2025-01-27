using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMediaNota
{
    internal class Imagen:Media
    {
        int anchura;
        int altura;

        public Imagen(string autor, int tamanoKB, string formato, int anchura, int altura) :base(autor, tamanoKB, formato)
        {
            this.anchura = anchura;
            this.altura = altura;
        }

        public int GetAnchura()
        {
            return anchura;
        }

        public int GetAltura()
        {
            return altura;
        }

        public void SetAnchura(int anchura)
        {
            this.anchura = anchura;
        }

        public void SetAltura(int altura)
        {
            this.altura = altura;
        }

        public override void Play()
        {
            Console.WriteLine("Imagen proyectando");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nAnchura: {anchura}\nAltura: {altura}";
        }
    }
}
