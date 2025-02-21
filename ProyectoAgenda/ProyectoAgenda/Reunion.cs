using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda
{
    internal class Reunion
    {
        string nombre;
        DateTime fechaHora;
        Contacto contacto;

        public Reunion(string nombre, DateTime fechaHora, Contacto contacto)
        {
            this.nombre = nombre;
            this.fechaHora = fechaHora;
            this.contacto = contacto;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public DateTime GetFechaHora()
        {
            return fechaHora;
        }

        public Contacto GetContacto()
        {
            return contacto;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaHora(DateTime fechaHora)
        {
            this.fechaHora = fechaHora;
        }

        public void SetContacto(Contacto contacto)
        {
            this.contacto = contacto;
        }

        public override string ToString()
        {
            return $"Reunión con {contacto.GetNombre()} el día {fechaHora.ToShortDateString()} a las {fechaHora.ToShortTimeString()}";
        }

    }
}
