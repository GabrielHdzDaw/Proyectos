using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotelFichero
{
    internal class Hotel
    {
        string nombre;
        string localidad;
        int estrellas;

        public Hotel(string nombre, string localidad, int estrellas)
        {
            this.nombre = nombre;
            this.localidad = localidad;
            this.estrellas = estrellas;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Localidad
        {
            get => localidad;
            set => localidad = value;
        }

        public int Estrellas
        {
            get => estrellas;
            set => estrellas = value;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Localidad: {localidad}, Estrellas: {estrellas}";
        }
    }
}
