using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoDomotica
{
    internal class Puerta:Dispositivo
    {
        bool bloqueado;
        public Puerta(string nombre, bool bloqueado) : base(nombre)
        {
            this.bloqueado = bloqueado;
        }

        public bool GetBloqueado()
        {
            return bloqueado;
        }

        public void Bloquear()
        {
            bloqueado = true;
        }

        public void Desbloquear()
        {
            bloqueado = false;
        }


        public override string ToString()
        {
            string bloqueadoString = bloqueado ? "Bloqueado" : "Desbloqueado";
            return base.ToString() + bloqueadoString;
        }
    }
}
