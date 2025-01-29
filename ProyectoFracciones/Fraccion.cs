using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFracciones
{
    internal class Fraccion
    {
        int numerador;
        int denominador;

        public Fraccion(int numerador, int denominador)
        {
            this.denominador = denominador;
            this.numerador = numerador;
        }

        public Fraccion(int numerador):this(0,0)
        {
            this.numerador = numerador;
        }

        public int getNumerador() 
        {
            return numerador;
        }

        public int GetDenominador()
        {
            return denominador;
        }

        public void SetNumerador(int numerador)
        {
            this.numerador = numerador;
        }

        public void SetDenominador(int denominador)
        {
            this.denominador = denominador;
        }

        private int MinimoComunDenominador()
        {

        }

        public static int operator +(Fraccion fraccion1, Fraccion fraccion2)
        {
            return new Fraccion(fraccion1.getNumerador(), );
        }


        public override string ToString()
        {
            return $"{numerador}/{denominador}";
        }
    }
}
