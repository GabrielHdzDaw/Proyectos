using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMoto
{
    internal class Moto
    {
        static int ruedas = 2;
        string marca;

        public Moto(string marca, int nuevasRuedas)
        {
            this.marca = marca;
            ruedas = nuevasRuedas;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetMarca()
        {
            return marca;
        }

        public void SetRuedas(int nuevasRuedas)
        {
            ruedas = nuevasRuedas;
        }

        public int GetRuedas()
        {
            return ruedas;
        }

        public override string ToString()
        {
            return $"Marca: {marca}  Ruedas: {ruedas}";
        }
    }
}
