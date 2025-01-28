using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDispositivos
{
    internal abstract class Dispositivo
    {
        string nombre;
        int velocidadProceso;
        double tamanoPantalla;
        
        public Dispositivo(string nombre, int velocidadProceso, double tamanoPantalla)
        {
            this.nombre = nombre;
            this.velocidadProceso = velocidadProceso;
            this.tamanoPantalla = tamanoPantalla;
        }

        public Dispositivo() : this("", 0, 0)
        {
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetVelocidadProceso()
        {
            return velocidadProceso;
        }

        public void SetVelocidadProceso(int velocidadProceso)
        {
            this.velocidadProceso = velocidadProceso;
        }

        public double GetTamanoPantalla()
        {
            return tamanoPantalla;
        }

        public void SetTamanoPantalla(double tamanoPantalla)
        {
            this.tamanoPantalla = tamanoPantalla;
        }

        public abstract void Conectar();

        public override string ToString()
        {
            return "Nombre: " + nombre + ", " + velocidadProceso + " Mb, " + tamanoPantalla + " pulgadas";
        }

    }
}
