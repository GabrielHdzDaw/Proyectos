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
        string dni;
        int edad;
        string curso;
        public Alumno(string nombre, string dni, int edad, string curso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.curso = curso;
            this.dni = dni;
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

        public string GetDni()
        {
            return dni;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        public int CompareTo(Alumno? alumno)
        {
            if (alumno == null) return 1;
            return edad.CompareTo(alumno.edad);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return dni == ((Alumno)obj).dni;
        }

        public static bool operator == (Alumno a1, Alumno a2)
        {
            return a1.Equals(a2);
        }

        public static bool operator != (Alumno a1, Alumno a2)
        {
            return !a1.Equals(a2);
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Edad: {edad}, Curso: {curso}";
        }
    }
}
