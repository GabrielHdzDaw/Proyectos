using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibros
{
    internal class Documento
    {
        protected string autor;
        protected string titulo;
        protected string ubicacion;
        public Documento(string autor, string titulo, string ubicacion) 
        {
            Console.WriteLine("Creando documento");
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }

        public string GetAutor()
        {
            return this.autor;
        }

        public string GetTitulo()
        {
            return this.titulo;
        }

        public string GetUbicacion()
        {
            return this.ubicacion;
        }
    }
}
