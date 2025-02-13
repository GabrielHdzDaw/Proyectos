using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema7
{
    internal class CentroAnalisis: Elemento
    {
        Muestra[] muestras;

        public CentroAnalisis(string nombre, int x, int y, bool estado):base(nombre, x,  y, estado)
        {
            muestras = new Muestra[5];
        }

        public void Analizar()
        {
            foreach(Muestra muestra in muestras)
            {
                Console.WriteLine($"Analizando muestra obtenida en terreno ({muestra.GetX()},{muestra.GetY()})");
            }
        }

        public override string ToString()
        {
            string muestrasString = "";
            
            foreach(Muestra muestra in muestras)
            {
                muestrasString += "\n" + muestra;
            }
            return base.ToString() + $"Muestras: {muestrasString} ";
        }
    }
}
