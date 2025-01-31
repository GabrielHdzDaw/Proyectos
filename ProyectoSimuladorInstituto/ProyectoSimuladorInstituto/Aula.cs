using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorInstituto
{
    internal class Aula
    {
        int numero;
        Alumno[] alumnos;

        public Aula(int numero, Alumno[] alumnos)
        {
            this.numero = numero;
            this.alumnos = alumnos;
        }

        public int GetNumero()
        {
            return numero;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public override string ToString()
        {
            return $"Número de aula: {numero}";
        }


    }
}
