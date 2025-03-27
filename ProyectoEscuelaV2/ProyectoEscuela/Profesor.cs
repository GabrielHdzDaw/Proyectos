using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuelaV2
{
    internal class Profesor : Persona
    {
        public List<string> Asignaturas { get; set; }
        public Profesor(string nombre, string direccion, DateTime fechaNacimiento, string localidad, string provincia, List<string> asignaturas) : base(nombre, direccion, fechaNacimiento, localidad, provincia)
        {
            Asignaturas = asignaturas;
        }

        public override string ToString()
        {
            return base.ToString() + $" Asignaturas: {string.Join(", ", Asignaturas)}";
        }
    }
}
