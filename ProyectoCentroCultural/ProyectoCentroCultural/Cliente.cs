using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCentroCultural
{
    internal class Cliente:IComparable<Cliente>
    {
        string dni;
        string nombre;
        Peticion[] peticiones;

        public Cliente(string dni, string nombre, Peticion[] peticiones)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.peticiones = peticiones;
        }

        public string GetDni()
        {
            return dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public Peticion[] GetPeticiones()
        {
            return peticiones;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetPeticiones(Peticion[] peticiones)
        {
            this.peticiones = peticiones;
        }

        public void MostrarPeticiones()
        {
            foreach (Peticion peticion in peticiones)
            {
                Console.WriteLine(peticion.ToString());
            }
        }

        public int CompareTo(Cliente? cliente)
        {
            if (cliente == null) return 1;
            return nombre.CompareTo(cliente.GetNombre());
        }

        public override string ToString()
        {
            string peticionesString = "";
            foreach (Peticion peticion in peticiones)
            {
                peticionesString += peticion + "\n";
            }
            return $"DNI: {dni}, Nombre: {nombre}\nPeticiones: {peticionesString}";
        }
    }
}
