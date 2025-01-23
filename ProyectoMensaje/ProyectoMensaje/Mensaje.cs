using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMensaje
{
    internal class Mensaje
    {
        string remite;
        string destino;
        string contenido;
        int fecha;

        public Mensaje()
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int anio = DateTime.Now.Year;
            string fechaString = dia.ToString("D2") + mes.ToString("D2") + anio.ToString();
            fecha = Convert.ToInt32(fechaString);
        }

        public string Remite
        {
            get
            {
                return remite;
            }
            set
            {
                remite = value;
            }
        }

        public string Destino
        {
            get
            {
                return destino;
            }
            set
            {
                destino = value;
            }
        }

        public string Contenido
        {
            get
            {
                return contenido;
            }
            set
            {
                contenido = value;
            }
        }

        public void SetFecha(string fecha)
        {
            string[] fechaSplit = fecha.Split('/');
            string fechaString = Convert.ToInt32(fechaSplit[0]).ToString("D2") + Convert.ToInt32(fechaSplit[1]).ToString("D2") + Convert.ToInt32(fechaSplit[2]).ToString("D2");
            this.fecha = Convert.ToInt32(fechaString);
        }

        public string GetFecha()
        {
            return $"{fecha / 1000000} / {(fecha /10000) % 100}  / {fecha % 10000}";
        }

        public override string ToString()
        {
            return $"Fecha: {GetFecha()}\nRemite: {remite}  Destino: {destino}\nMensaje: {contenido}";
        }
    }
}
