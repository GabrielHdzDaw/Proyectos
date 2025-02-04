using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDomotica
{
    internal class Horno :Dispositivo, IEncendible, ITemperatura
    {
        private string nombre;
        private bool encendido;
        private int temperatura;
        public Horno(string nombre, bool encendido, int temperatura) : base(nombre)
        {
            this.encendido = encendido;
            this.temperatura = temperatura;
        }
        public Horno(int temperatura) : this("Horno", false, temperatura)
        {
        }
        public void CambiarEstado()
        {
            encendido = !encendido;
        }
        public void CambiarTemperatura(int temperatura)
        {
            this.temperatura = temperatura;
        }
        public bool GetEncendido()
        {
            return encendido;
        }
        public int GetTemperatura()
        {
            return temperatura;
        }
        public override string ToString()
        {
            return base.ToString() +  "Estado: " + (encendido ? "encendido" : "apagado") + " Temperatura: {temperatura}";
        }
    }
}

