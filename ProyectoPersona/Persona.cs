using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersona
{
    internal class Persona
    {
        protected string nombre;
        int edad;
        int altura;

        public Persona(string nombre, int edad, int altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
        }
        public Persona() : this("juan", 70, 0)
        {
            
        }
        public Persona(string nombre) : this("juan", 70, 0)
        {
            this.nombre = nombre;
        }

        public Persona(string nombre, int edad): this("juan", 70, 0)
        {
            this.nombre = nombre;
            this.edad = edad;
            
        }

        


        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int GetEdad()
        {
            return edad;
        }

        public void SetAltura(int altura)
        {
            this.altura = altura;
        }
        public int GetAltura()
        {
            return altura;
        }

        

        virtual public void Saludar()
        {
            Console.WriteLine($"Hola, soy {this.nombre}");
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}\nEdad: {edad}\nAltura: {altura}";
        }
    }
}
