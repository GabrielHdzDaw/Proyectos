using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoV2
{
    internal abstract class Obra:IComparable<Obra>
    {
        Autor autor;
        string propietario;
        string nombre;
        int ano;

        public Obra(Autor autor, string propietario, string nombre, int ano)
        {
            this.autor = autor;
            this.propietario = propietario;
            this.nombre = nombre;
            this.ano = ano;
        }

        public Autor GetAutor()
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
            return ano;
        }
        
        public void SetAutor(Autor autor) 
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

        public void SetAno(int ano)
        {
            this.ano = ano;
        }

        public int CompareTo(Obra obra)
        {
            if (ano == obra.GetAno())
            {
                return nombre.CompareTo(obra.GetNombre());
            }
            return ano.CompareTo(obra.GetAno());
        }

        public override string ToString()
        {
            return $"\nPintura: {GetNombre()}\nAutor: {GetAutor()}\nAño: {GetAno()}\nPropietario: {GetPropietario()}";
        }
    }
}
