using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMediaNota
{
    internal class Sonido:Media
    {
        bool stereo = false;
        int kbps;
        int longitud;

        public Sonido(string autor, int tamanoKB, string formato, bool stereo, int kbps, int longitud) :base(autor, tamanoKB, formato)
        {
            this.stereo = stereo;
            this.kbps = kbps;
            this.longitud = longitud;
        }

        public bool GetStereo()
        {
            return stereo;
        }

        public int GetKbps()
        {
            return kbps;
        }

        public int GetLongitud()
        {
            return longitud;
        }

        public void SetStereo(bool stereo)
        {
            this.stereo = stereo;
        }

        public void SetKbps(int kbps)
        {
            this.kbps = kbps;
        }

        public void SetLongitud(int longitud)
        {
            this.longitud = longitud;
        }

        public override void Play()
        {
            Console.WriteLine("Sonido sonando");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nStereo: {stereo}\nKbps: {kbps}\nDuración: {longitud}";
        }
    }
}
