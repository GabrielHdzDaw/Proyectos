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
                        electrodomesticos.Add(new Blanca(campos[0], campos[1], campos[2], double.Parse(campos[3]), double.Parse(campos[4]), char.Parse(campos[5])));
                        break;
                    case "gris":
                        electrodomesticos.Add(new Gris(campos[0], campos[1], campos[2], double.Parse(campos[3]), double.Parse(campos[4]), char.Parse(campos[5])));
                        break;
                    case "marron":
                        electrodomesticos.Add(new Marron(campos[0], campos[1], campos[2], double.Parse(campos[3]), double.Parse(campos[4]), char.Parse(campos[5])));
                        break;
                    case "pae":
                        electrodomesticos.Add(new Pae(campos[0], campos[1], campos[2], double.Parse(campos[3]), double.Parse(campos[4]), char.Parse(campos[5])));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
