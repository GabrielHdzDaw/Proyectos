using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibros
{
    internal class Libro:Documento
    {
        protected int paginas;

        public void SetPaginas(int paginas)
        { 
            this.paginas = paginas; 
        } 
        public int GetPaginas() 
        {
            return this.paginas;
        }

        //public void SetAutor(string autor)
        //{
        //    this.autor = autor; 
        //}

        //public void SetTitulo(string titulo)
        //{
        //    this.titulo = titulo;
        //}

        //public void SetUbicacion(string ubicacion)
        //{
        //    this.ubicacion = ubicacion;
        //}
        
        //public string GetAutor()
        //{
        //    return this.autor; 
        //}

        //public string GetTitulo()
        //{
        //    return this.titulo;
        //}

        //public string GetUbicacion()
        //{
        //    return this.ubicacion;
        //}
    }
}
