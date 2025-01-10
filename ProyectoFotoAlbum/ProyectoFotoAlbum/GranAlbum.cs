using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoAlbum
{
    internal class GranAlbum:FotoAlbum
    {
        public GranAlbum():base(64) 
        { }

        public override string ToString()
        {
            return base.ToString() + " y soy grande";
        }
    }
}
