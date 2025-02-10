using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFlota
{
    internal interface ICargable
    {
        void Cargar();
        void EnviarACargar(EstacionCarga estacion);
    }
}
