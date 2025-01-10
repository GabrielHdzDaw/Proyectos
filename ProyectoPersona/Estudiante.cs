using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersona
{
    internal class Estudiante: Persona
    {
        string curso;

        public void SetCurso(string curso)
        {
            this.curso = curso;
        }

        public string GetCurso()
        {
            return curso;
        }
    }
}
