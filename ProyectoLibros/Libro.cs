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

        public Libro(string autor, string titulo, string ubicacion, int paginas) : base(autor, titulo, ubicacion) 
        {
            Console.WriteLine("Creando libro");
            this.paginas = paginas;
        }

        public Libro(string autor, string titulo) : base(autor, titulo, "No detallada")
        {
            Console.WriteLine("Creando libro");
        }
        public void SetPaginas(int paginas)
        { 
            this.paginas = paginas; 
        } 
        public int GetPaginas() 
        {
            return this.paginas;
        }

        
    }
}
