using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda
{
    internal class Contacto: IComparable<Contacto>
    {
        string nombre;
        string puesto;
        string empresa;
        public Contacto(string nombre, string puesto, string empresa)
        {
            this.nombre = nombre;
            this.puesto = puesto;
            this.empresa = empresa;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetPuesto()
        {
            return puesto;
        }

        public string GetEmpresa()
        {
            return empresa;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetPuesto(string puesto)
        {
            this.puesto = puesto;
        }

        public void SetEmpresa(string empresa)
        {
            this.empresa = empresa;
        }

        public override bool Equals(object obj)
        {
            return obj is Contacto contacto &&
                   nombre == contacto.nombre &&
                   puesto == contacto.puesto &&
                   empresa == contacto.empresa;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Puesto: {puesto}, Empresa: {empresa}";
        }

        public int CompareTo(Contacto? contacto)
        {
            if (contacto == null)
            {
                return 1;
            }
            return nombre.CompareTo(contacto.nombre);
        }
    }
}
