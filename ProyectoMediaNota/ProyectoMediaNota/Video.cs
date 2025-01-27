using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMediaNota
{
    internal class Video:Imagen
    {
        string codec;
        int longitud;

        public Video(string autor, int tamanoKB, string formato, int anchura, int altura, string codec, int longitud) :base(autor, tamanoKB, formato, anchura, altura)
        {
            this.codec = codec;
            this.longitud = longitud;
        }

        public string GetCodec()
        {
            return codec;
        }

        public int GetLongitud()
        {
            return longitud;
        }

        public void SetCodec(string codec)
        {
            this.codec = codec;
        }

        public void SetLongitud(int longitud)
        {
            this.longitud = longitud;
        }

        public override void Play()
        {
            Console.WriteLine("Video Imagen proyectando");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCodec: {codec}\nLongitud: {longitud}";
        }
    }
}
