using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorInstituto
{
    internal abstract class Persona
    {
        string nombre;
        int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
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

        public abstract void MostrarEstado();


        public abstract void Animar15minutos(DateTime fecha);
       

        public override string ToString()
        {
            return $"Nombre: {nombre}, Edad: {edad}";
        }
    }
}
