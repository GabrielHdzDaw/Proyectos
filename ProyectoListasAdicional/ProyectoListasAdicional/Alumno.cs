using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListasAdicional
{
    internal class Alumno: IComparable<Alumno>
    {
        Random generator = new Random();
        string dni;
        string nombre;
        string apellidos;
        int edad;
        List<int> notas = new List<int>();

        public Alumno(string nombre, string apellidos, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            dni = generator.Next(10000000, 99999999).ToString();
            for (int i = 0; i < 3; i++)
            {
                notas.Add(generator.Next(0, 10));
            }
        }

        public string GetDni()
        {
            return dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetApellidos()
        {
            return apellidos;
        }

        public int GetEdad()
        {
            return edad;
        }

        public List<int> GetNotas()
        {
            return notas;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetNotas(List<int> notas)
        {
            this.notas = notas;
        }

        public double GetMedia()
        {
            return notas.Average();
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        public bool Tiene5()
        {
            return notas.Contains(5);
        }

        public override string ToString()
        {
            return $"Nombre: {nombre} {apellidos}, DNI: {dni}, Edad: {edad}, Notas: {string.Join(", ", notas)}, Media: {GetMedia()}";
        }

        public int CompareTo(Alumno? alumno)
        {
            if (alumno == null) return 1;
            return edad.CompareTo(alumno.GetEdad());
        }

        
    }
}
