using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCabanas
{
    internal class Persona
    {
        string nombre;
        string apellidos;
        DateTime fechaNacimiento;
        Alergia[] alergias;

        public Persona(string nombre, string apellidos, DateTime fechaNacimiento, Alergia[] alergias)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.alergias = alergias;
        }

        public int GetEdad()
        {
            return DateTime.Now.Year - fechaNacimiento.Year;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetApellidos()
        {
            return apellidos;
        }

        public string GetFechaNacimiento()
        {
            return fechaNacimiento.ToString("dd/MM/yyyy");
        }

        public Alergia[] GetAlergias()
        {
            return alergias;
        }

    }
}
