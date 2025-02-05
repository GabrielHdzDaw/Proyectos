using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDomotica
{
    internal interface ISubible
    {
        public void Subir();
        public void Bajar();
        public void Subir(int porcentaje);
        public void Bajar(int porcentaje);
        
    }
}
