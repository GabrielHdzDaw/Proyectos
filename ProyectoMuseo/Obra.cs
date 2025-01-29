using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseo
{
    internal abstract class Obra:IComparable<Obra>
    {
        string autor;
        string propietario;
        string nombre;
        int año;

        public Obra(string autor, string propietario, string nombre, int año)
        {
            this.autor = autor;
            this.propietario = propietario;
            this.nombre = nombre;
            this.año = año;
        }

        public string GetAutor()
        {
            return autor;
        }

        public string GetPropietario() 
        {
            return propietario;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetAno()
        {
            return año;
        }
        
        public void SetAutor(string autor) 
        {
            this.autor = autor;
        }

        public void SetPropietario(string propietario)
        {
            this.propietario = propietario;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetAño(int año)
        {
            this.año = año;
        }

        public int CompareTo(Obra obra)
        {
            if (año == obra.GetAño())
            {
                return nombre.CompareTo(obra.GetNombre());
            }
            return año.CompareTo(obra.GetAño());
        }

        public override string ToString()
        {
            return $"\nPintura: {GetNombre()}\nAutor: {GetAutor()}\nAño: {GetAño()}\nPropietario: {GetPropietario()}";
        }
    }
}
