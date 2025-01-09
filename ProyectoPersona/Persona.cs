using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersona
{
    internal class Persona
    {
        string nombre;
        int edad;
        string direccion;


        public Persona (string nombre, int edad, string direccion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
            edad = 0;
            direccion = "";
        }

        public Persona()
        {
            nombre = "Fulanito";
            edad = 0;
            direccion = "";
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {this.nombre}");
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}\nEdad: {edad}\nDirección: {direccion}\n";
        }
    }
}
