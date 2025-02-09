using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCabanas
{
    internal abstract class Persona:IComparable<Persona>
    {
        protected string nombre;
        protected string apellidos;
        protected DateTime fechaNacimiento;
       

        public Persona(string nombre, string apellidos, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
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

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public int CompareTo(Persona persona)
        {
            return apellidos.CompareTo(persona.GetApellidos());
        }

        public override string ToString()
        {
            return $"Apellido, nombre: {apellidos}, {nombre} | Edad: {GetEdad()} |";
        }

    }
}
