using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuela
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public Persona(string nombre, string direccion, DateTime fechaNacimiento, string localidad, string provincia)
        {
            Nombre = nombre;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Localidad = localidad;
            Provincia = provincia;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Dirección: {Direccion}, Fecha nac.: {FechaNacimiento.ToString("dd/MM/yyyy")}, Localidad: {Localidad}, Provincia: {Provincia},";
        }
    }
}
