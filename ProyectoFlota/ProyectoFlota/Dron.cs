using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFlota
{
    internal class Dron : Vehiculo, ICargable
    {
        int porcentajeBateria;
        int altitud;
        Camara camara;

        public Dron(string nombre, bool activo, int x, int y, int porcentajeBateria, int altitud, Camara camara) : base(nombre, activo, x, y)
        {
            this.porcentajeBateria = porcentajeBateria;
            this.altitud = altitud;
            this.camara = camara;

        }

        public Dron(string nombre) : base(nombre)
        {
            porcentajeBateria = 100;
            altitud = 0;
            camara = new Camara("Camara1", "Modelo1", "Resolucion1");
        }
        public int GetPorcentajeBateria()
        {
            return porcentajeBateria;
        }
        public void SetPorcentajeBateria(int porcentajeBateria)
        {
            this.porcentajeBateria = porcentajeBateria;
        }

        public int GetAltitud()
        {
            return altitud;
        }

        public void SetAltitud(int altitud)
        {
            this.altitud = altitud;
        }

        public Camara GetCamara()
        {
            return camara;
        }

        public void SetCamara(Camara camara)
        {
            this.camara = camara;
        }

        public void MoverDron(int x, int y, int altitud)
        {
            SetX(x);
            SetY(y);
            SetAltitud(altitud);
        }

        public override void Mover(int x, int y)
        {
            SetX(x);
            SetY(y);
        }
        public void EnviarACargar(EstacionCarga estacion)
        {
            MoverDron(estacion.GetX(), estacion.GetY(), 0);
            Cargar();
        }
        public void Cargar()
        {
            porcentajeBateria += 50;
            porcentajeBateria = porcentajeBateria > 100 ? 100 : porcentajeBateria;
        }

        public void CapturaImagenes()
        {
            Console.WriteLine("Capturando imágenes");
            camara.CapturaImagenes(GetX(), GetY(), GetAltitud());
        }
        public override string ToString()
        {
            return base.ToString() + $" Altitud: {altitud} | Cámara: {camara}";
        }
    }
}
