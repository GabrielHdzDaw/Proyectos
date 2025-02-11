using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListaCompra
{
    internal class Usuario
    {
        string nombre;
        string contrasena;

        public Usuario(string nombre, string contrasena)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetContrasena()
        {
            return contrasena;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetContrasena(string contrasena)
        {
            this.contrasena = contrasena;
        }

        public override string ToString()
        {
            return $"Usuario: {nombre}";
        }
}
