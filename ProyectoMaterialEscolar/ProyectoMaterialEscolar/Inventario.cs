using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMaterialEscolar
{
    internal class Inventario 
    {
        SortedList<Material, int> materiales;
        public Inventario()
        {
            
            materiales = new SortedList<Material, int>();
            string[] lineas = File.ReadAllLines(@"..\..\..\materialEscolar.txt");
            foreach (var line in lineas)
            {
                string[] parts = line.Split(';');
                string nombre = parts[0];
                string marca = parts[1];
                double precio = Convert.ToDouble(parts[2]);
                int cantidad = Convert.ToInt32(parts[3]);
                Material material = new Material(nombre, marca, precio);
                materiales.Add(material, cantidad);
            }
        }

        public void MostrarMateriales()
        {
            foreach (var material in materiales)
            {
                Console.WriteLine(material);
            }
        }

        public void AnadirMaterial(Material material, int cantidad)
        {
                materiales.Add(material, cantidad);
        }

        public void ActualizarCantidad(Material material, int cantidad)
        {
            if (materiales.ContainsKey(material))
            {
                materiales[material] = cantidad;
            }
            else
            {
                Console.WriteLine("Ese material no existe");
            }
        }
    }
}
