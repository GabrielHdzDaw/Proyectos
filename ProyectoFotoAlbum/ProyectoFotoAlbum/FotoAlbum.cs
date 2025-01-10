using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoAlbum
{
    internal class FotoAlbum
    {
        int numeroPaginas;

        public FotoAlbum(int numeroPaginas)
        {
            this.numeroPaginas = numeroPaginas;
        }

        public FotoAlbum():this(16) 
        {

        }

        public void SetNumeroPaginas(int numeroPaginas)
        {
            this.numeroPaginas = numeroPaginas;
        }

        public int GetNumeroPaginas() 
        { 
            return this.numeroPaginas;
        }

        public override string ToString()
        {
            return $"Soy un álbum de {numeroPaginas} páginas";
        }

    }
}
