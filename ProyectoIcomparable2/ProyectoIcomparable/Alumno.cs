using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIcomparable
{
    internal class Alumno : IComparable<Alumno>
    {
        string nombre;
        int edad;
        string curso;
        public Alumno(string nombre, int edad, string curso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.curso = curso;
        }
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetEdad()
        {
            return edad;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public string GetCurso()
        {
            return curso;
        }

        public void SetCurso(string curso)
        {
            this.curso = curso;
        }

        public int CompareTo(Alumno? alumno)
        {
            if (alumno == null) return 1;
            return edad.CompareTo(alumno.edad);
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Edad: {edad}, Curso: {curso}";
        }
    }
}
