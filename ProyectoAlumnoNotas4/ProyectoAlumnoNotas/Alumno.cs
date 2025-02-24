using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlumnoNotas
{
    internal class Alumno
    {
        string dni;
        string nombre;
        List<float> notas;

        public Alumno(string dni, string nombre, List<float> notas)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.notas = notas;
        }

        public string GetDni()
        {
            return dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public List<float> GetNotas()
        {
            return notas;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetNotas(List<float> notas)
        {
            this.notas = notas;
        }

        public float CalcularMedia()
        {
            float suma = 0;
            foreach (float nota in notas)
            {
                suma += nota;
            }
            return suma / notas.Count;
        }

        public override string ToString()
        {
            return $"DNI: {dni}, Nombre: {nombre}, Notas: {string.Join(", ", notas)}";
        }
    }
}
