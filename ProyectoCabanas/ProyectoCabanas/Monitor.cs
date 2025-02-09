using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCabanas
{
    internal class Monitor:Persona  
    {
        int especialidad;
        public Monitor(string nombre, string apellidos, DateTime fechaNacimiento, int especialidad):base(nombre, apellidos, fechaNacimiento)
        {
            this.especialidad = especialidad;
        }

        public int GetEspecialidad()
        {
            return especialidad;
        }

        public void SetEspecialidad(int especialidad)
        {
            this.especialidad = especialidad;
        }

        public override string ToString()
        {
            return base.ToString() + $"Especialidad: {especialidad}";
        }
    }
    
}
