using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema7
{
    internal class Camara:Elemento
    {
        int id;
        string modelo;

        public Camara(string nombre, int x, int y, bool estado, int id, string modelo):base(nombre, x, y, estado)
        {
            this.id = id;
            this.modelo = modelo;
        }

        public string RevisarTerreno(Parcela parcela)
        {
            return parcela.GetTerreno();
        }

        public override string ToString()
        {
            return base.ToString() + $"ID: {id}, Modelo: {modelo} ";
        }
    }
}
