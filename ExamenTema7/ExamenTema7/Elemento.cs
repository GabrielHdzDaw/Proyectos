using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema7
{
    internal class Elemento: IComparable<Elemento>
    {
        string nombre;
        int x;
        int y;
        bool estado;

        public Elemento(string nombre, int x, int y, bool estado)
        {
            this.nombre = nombre;
            this.x = x;
            this.estado = estado;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public bool GetEstado()
        {
            return estado;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetX(int x)
        {
            this.x = x; 
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetEstado(bool estado)
        {
            this.estado = estado;
        }

        public int CompareTo(Elemento? elemento)
        {
            if (this == elemento) return 0;
            return nombre.CompareTo(elemento?.nombre);
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Coordenadas: ({x}, {y}), Estado: {estado} ";
        }
    }
}
