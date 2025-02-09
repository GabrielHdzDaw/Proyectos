using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCabanas
{
    internal class Alumno : Persona
    {
        int telefono;
        int edad;
        public Alumno(string nombre, string apellidos, DateTime fechaNacimiento, int telefono) : base(nombre, apellidos, fechaNacimiento)
        {
            this.telefono = telefono;
            this.edad = GetEdad();
        }

        public int GetTelefono()
        {
            return telefono;
        }

        public void SetTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return base.ToString() + $" Telefono: {telefono}";
        }
    }
}
