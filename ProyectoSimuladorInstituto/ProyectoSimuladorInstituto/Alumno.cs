using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorInstituto
{
    internal class Alumno:Persona
    {
        int aula;

        public Alumno(string nombre, int edad, int aula) : base(nombre, edad)
        {
            this.aula = aula;
        }

        public Alumno(int aula):this("alumno", 0, aula)
        {
            this.aula = aula;
        }

        public int GetAula()
        {
            return aula;
        }

        public void SetAula(int aula)
        {
            this.aula = aula;
        }

        public override string ToString()
        {
            return base.ToString() + $"Aula: {aula}";
        }
    }
}
