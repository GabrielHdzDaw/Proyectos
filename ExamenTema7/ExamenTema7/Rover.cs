using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema7
{
    internal class Rover : Vehiculo
    {

        Camara camara;

        public Rover(string nombre, int x, int y, bool estado, int bateria, Camara camara) : base(nombre, x, y, estado, bateria)
        {
            this.camara = camara;
        }

        public Camara GetCamara()
        {
            return camara;
        }

        public void SetCamara(Camara camara)
        {
            this.camara = camara;
        }

        public bool RevisarTerreno(Parcela parcela)
        {
            return camara.RevisarTerreno(parcela) == "terreno estable";
        }

        public override string ToString()
        {
            return base.ToString() + $"Cámara: {camara} ";
        }
    }
}
