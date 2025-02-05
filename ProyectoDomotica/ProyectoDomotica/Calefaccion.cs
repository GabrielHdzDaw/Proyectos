using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDomotica
{
    internal class Calefaccion:Dispositivo, ITemperatura, IEncendible
    {
        int temperatura;
        bool encendido = false;

        public Calefaccion(string nombre, bool encendido, int temperatura) : base(nombre)
        {
            this.temperatura = temperatura;
            this.encendido = encendido;
        }

        public Calefaccion(int temperatura):this("Calefaccion", false, temperatura)
        {

        }
        public int GetTemperatura()
        {
            return temperatura;
        }

        public bool GetEncendido()
        {
            return encendido;
        }

        public void CambiarTemperatura(int temperatura)
        {
            this.temperatura = temperatura;
        }

        public void CambiarEstado()
        {
            encendido = !encendido;
        }

        public override string ToString()
        {

            return base.ToString() + (encendido ? "encendida" : "apagada") + " Temperatura: " + temperatura;
        }
    }
}
