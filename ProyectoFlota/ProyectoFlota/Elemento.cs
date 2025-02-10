using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFlota
{
    internal abstract class Elemento
    {
        string nombre;
        bool activo = false;

        public Elemento(string nombre, bool activo)
        {
            this.nombre = nombre;
            this.activo = activo;
        }

        public Elemento(string nombre)
        {
            this.nombre = nombre;
            activo = false;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public bool GetActivo()
        {
            return activo;
        }

        public void SetActivo(bool activo)
        {
            this.activo = activo;
        }

        public abstract void Activar();
        public abstract void Desactivar();

        public override string ToString()
        {
            return $"Nombre: {nombre} | Estado: " + (activo ? "activo | " : "inactivo | ");
        }
    }
}
