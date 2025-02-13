using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema7
{
    internal class Parcela
    {
        int x;
        int y;
        string terreno;

        public Parcela(int x, int y, string terreno)
        {
            this.x = x;
            this.y = y;
            this.terreno = terreno;
        }

        public int getX() { return x; }
        public int getY() { return y; }
        public string getTerreno() { return terreno; }

        public void setTerreno(string terreno)
        {
            this.terreno = terreno;
        }

        public void setX(int x) 
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public override string ToString()
        {
            return $"Coordenadas: ({x}, {y}), Terreno: {terreno} ";
        }

    }
}
