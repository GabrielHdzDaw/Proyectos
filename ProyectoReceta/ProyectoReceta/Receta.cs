using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoReceta
{
    internal class Receta
    {
        string nombre;
        string categoria;
        int calorias;

        public Receta(string nombre, string categoria, int calorias)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.calorias = calorias;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetCategoria()
        {
            return categoria;
        }

        public int GetCalorias()
        {
            return calorias;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public void SetCalorias(int calorias)
        {
            this.calorias = calorias;
        }

        public override string ToString()
        {
            return $"Receta: {nombre}, Categoria: {categoria}, Calorias: {calorias}";
        }
    }
}
