using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCentroCultural
{
    internal class Libro:Material
    {
        int paginas;

        public Libro(int codigo, string titulo, string autor, int paginas) : base(codigo, titulo, autor)
        {
            this.paginas = paginas;
        }

        public int GetPaginas()
        {
            return paginas;
        }

        public void SetPaginas(int paginas)
        {
            this.paginas = paginas;
        }

        public override string ToString()
        {
            return base.ToString() + $", Páginas: {paginas}";
        }
    }
}
