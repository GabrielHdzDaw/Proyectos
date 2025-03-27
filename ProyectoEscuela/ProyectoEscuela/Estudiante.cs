using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuela
{
    internal class Estudiante:Persona
    {
        public Dictionary<string, double> Asignaturas { get; set; }
        public Estudiante(string nombre, string direccion, DateTime fechaNacimiento, string localidad, string provincia, Dictionary<string, double> asignaturas) : base(nombre, direccion, fechaNacimiento, localidad, provincia)
        {
            Asignaturas = asignaturas;
        }

        public override string ToString()
        {
            return base.ToString() + $" Asignaturas: {string.Join(", ", Asignaturas.Select(a => $"{a.Key}: {a.Value}"))}";
        }
    }
}
