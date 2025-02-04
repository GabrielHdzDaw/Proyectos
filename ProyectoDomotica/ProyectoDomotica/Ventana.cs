using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDomotica
{
    internal class Ventana:Dispositivo
    {
        Persiana persiana;

        public Ventana(string nombre, Persiana persiana): base(nombre)
        {
            this.persiana = persiana;
        }

        public Persiana GetPersiana()
        {
            return persiana;
        }

        public void Abrir(int porcentaje)
        {
            persiana.Subir(porcentaje > 100 ? 100 : porcentaje < 0 ? 0 : porcentaje);
        }

        public override string ToString() 
        {
            return base.ToString() + persiana;
        }
}
