using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema7
{
    
    internal class RobotExcavador: Vehiculo
    {
        Muestra[] muestras;
        int i = 0;
        public RobotExcavador(string nombre, int x, int y, bool estado, int bateria) : base(nombre, x, y, estado, bateria)
        {
            muestras = new Muestra[5];
        }

        public void RecogerMuestra()
        {
            if (i == 4)
            {
                DescargarMuestras();
                i = 0;
            }
            else
            {
                muestras[i] = new Muestra($"Muestra{i + 1}", GetX(), GetY(), true);
                i++;
            }
        }

        public void DescargarMuestras(CentroAnalisis centro)
        {
            
        }


    }
}
