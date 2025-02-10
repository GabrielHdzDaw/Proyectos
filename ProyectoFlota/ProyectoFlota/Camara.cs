using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFlota
{
    internal class Camara : Elemento
    {
        string nombre;
        string modelo;
        string resolucion;
        public Camara(string nombre, string modelo, string resolucion) : base(nombre)
        {
            this.nombre = nombre;
            this.modelo = modelo;
            this.resolucion = resolucion;
        }

        public string GetModelo()
        {
            return modelo;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetResolucion()
        {
            return resolucion;
        }
        public void SetResolucion(string resolucion)
        {
            this.resolucion = resolucion;
        }
        public override void Activar()
        {
            SetActivo(true);
        }
        public override void Desactivar()
        {
            SetActivo(false);
        }

        public void CapturaImagenes(int x, int y, int altitud)
        {
            Console.WriteLine($"Capturando imagen en coordenadas: {x},{y},{altitud}");
        }

        public override string ToString()
        {
            return base.ToString() + $"Nombre: {nombre} | Modelo: {modelo} | Resolución: {resolucion}";
        }
    }
}
