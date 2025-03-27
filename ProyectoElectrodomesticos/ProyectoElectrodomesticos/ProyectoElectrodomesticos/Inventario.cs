using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoElectrodomesticos
{
    internal class Inventario
    {
        List<Electrodomestico> electrodomesticos;

        public Inventario()
        {
            electrodomesticos = new List<Electrodomestico>();
        }


        public List<Electrodomestico> GetElectrodomesticos()
        {
            return electrodomesticos;
        }

        public void SetElectrodomesticos(List<Electrodomestico> value)
        {
            electrodomesticos = value;
        }

        public void AnadirElectrodomestico(Electrodomestico electrodomestico)
        {
            electrodomesticos.Add(electrodomestico);
        }

        public void BorrarElectrodomestico(string id)
        {
            electrodomesticos.Remove(electrodomesticos.Find(e => e.Codigo == id));
        }

        public void ModificarElectrodomestico(Electrodomestico electrodomestico)
        {
            int indice = electrodomesticos.IndexOf(electrodomestico);
            electrodomesticos[indice] = electrodomestico;
        }
        public void CrearElectrodomestico(Inventario inventario)
        {
            Console.Write("Introduce la gama del electrodoméstico (blanca, gris, marron o pae): ");
            string gama = Console.ReadLine();
            Console.Write("Introduce la descripción del electrodoméstico: ");
            string descripcion = Console.ReadLine();
            Console.Write("Introduce el modelo del electrodoméstico: ");
            string modelo = Console.ReadLine();
            Console.Write("Introduce el precio de coste del electrodoméstico: ");
            double precioCoste = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el precio de venta del electrodoméstico: ");
            double precioVenta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el consumo energético del electrodoméstico: ");
            string consumoEnergetico = Console.ReadLine();
            Console.Write("Introduce la cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Electrodomestico electrodomestico = null;
            switch (gama)
            {
                case "blanca":
                    electrodomestico = new Blanca(descripcion, modelo, gama, precioCoste, precioVenta, consumoEnergetico, cantidad);
                    break;
                case "gris":
                    electrodomestico = new Gris(descripcion, modelo, gama, precioCoste, precioVenta, consumoEnergetico, cantidad);
                    break;
                case "marron":
                    electrodomestico = new Marron(descripcion, modelo, gama, precioCoste, precioVenta, consumoEnergetico, cantidad);
                    break;
                case "pae":
                    electrodomestico = new Pae(descripcion, modelo, gama, precioCoste, precioVenta, consumoEnergetico, cantidad);
                    break;
                default:
                    Console.Write("Gama no válida");
                    break;
            }

            
            inventario.AnadirElectrodomestico(electrodomestico);
        }

        public void MostrarElectrodomesticos()
        {
            foreach (Electrodomestico e in electrodomesticos)
            {
                if (e is Blanca)
                {
                    Console.Write("Gama: Blanca, ");
                }
                else if (e is Gris)
                {
                    Console.Write("Gama: Gris, ");
                }
                else if (e is Marron)
                {
                    Console.Write("Gama: Marron, ");
                }
                else if (e is Pae)
                {
                    Console.Write("Gama: Pae, ");
                }
                Console.WriteLine(e);
                Console.WriteLine();
            }
        }

        public void BorrarUnElectrodomestico()
        {
            Console.WriteLine("Introduce el código del electrodoméstico que quieres borrar: ");
            string codigo = Console.ReadLine();
            
            BorrarElectrodomestico(codigo);
        }

        public void LeerFichero(string fichero)
        {
            string ruta = @$"..\..\..\{fichero}.txt";

            string[] lineas = File.ReadAllLines(ruta);
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(';');

                switch (fichero)
                {
                    case "blanca":
                        electrodomesticos.Add(new Blanca(campos[0], campos[1], campos[2], double.Parse(campos[3]), 
                            double.Parse(campos[4]), campos[5], int.Parse(campos[6])));
                        break;
                    case "gris":
                        electrodomesticos.Add(new Gris(campos[0], campos[1], campos[2], double.Parse(campos[3]), 
                            double.Parse(campos[4]), campos[5], int.Parse(campos[6])));
                        break;
                    case "marron":
                        electrodomesticos.Add(new Marron(campos[0], campos[1], campos[2], double.Parse(campos[3]), 
                            double.Parse(campos[4]), campos[5], int.Parse(campos[6])));
                        break;
                    case "pae":
                        electrodomesticos.Add(new Pae(campos[0], campos[1], campos[2], double.Parse(campos[3]),
                            double.Parse(campos[4]), campos[5], int.Parse(campos[6])));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
