using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMaterialEscolar
{
    internal class Material : IComparer<Material>, IComparable<Material>
    {
        string nombre;
        string marca;
        double precio;

        public Material(string nombre, string marca, double precio)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetMarca()
        {
            return marca;
        }

        public double GetPrecio()
        {
            return precio;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public void SetPrecio(double precio)
        {
            this.precio = precio;
        }

        public int Compare(Material a, Material b)
        {
            return (a == null || b == null) ? 0 : a.GetNombre().CompareTo(b.GetNombre()) != 0
                ? a.GetNombre().CompareTo(b.GetNombre())
                : a.GetMarca().CompareTo(b.GetMarca());
        }

        public int CompareTo(Material material)
        {
            return (material == null) ? 0 : this.GetNombre().CompareTo(material.GetNombre()) != 0
                ? this.GetNombre().CompareTo(material.GetNombre())
                : this.GetMarca().CompareTo(material.GetMarca());
        }

        public bool Equals(Material a, Material b)
        {
            return a.GetNombre().CompareTo(b.GetNombre()) == 0 && a.GetMarca().CompareTo(b.GetMarca()) == 0 ? true : false;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Marca: {marca}, Precio: {precio}";
        }
    }
}
