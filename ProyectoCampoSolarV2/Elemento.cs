using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCampoSolar
{
    internal class Elemento:IEncendible, IComparable<Elemento>
    {
        string nombre;
        bool encendido = false;

        public Elemento(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public bool GetEncendido()
        {
            return encendido;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Encender()
        {
            encendido = true;
        }

        public void Apagar()
        {
            encendido = false;
        }

        public int CompareTo(Elemento? elemento)
        {
            if (elemento == null)
            {
                return 1;
            }
            return nombre.CompareTo(elemento.GetNombre());
        }

        public override string ToString()
        {
            return nombre + " " + (encendido ? "encendido" : "apagado");
        }
    }
}
