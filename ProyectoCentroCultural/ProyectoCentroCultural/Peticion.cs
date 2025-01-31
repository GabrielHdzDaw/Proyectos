using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCentroCultural
{
    internal class Peticion
    {
        Material material;
        string fechaInicio;
        string fechaFin;

        public Peticion(Material material, string fechaInicio, string fechaFin)
        {
            this.material = material;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        public Material GetMaterial()
        {
           return material;
        }

        public string GetFechaInicio()
        {
           return fechaInicio;
        }

        public string GetFechaFin()
        {
           return fechaFin;
        }

        public void SetMaterial(Material material)
        {
           this.material = material;
        }

        public void SetFechaInicio(string fechaInicio)
        {
           this.fechaInicio = fechaInicio;
        }

        public void SetFechaFin(string fechaFin)
        {
           this.fechaFin = fechaFin;
        }

        public override string ToString()
        {
            return $"Material: {material.GetTitulo()}, Fecha de inicio: {fechaInicio}, Fecha fin: {fechaFin}";
        }
    }
}
