using System;
using System.Collections.Generic;
using System.Text;

namespace Fracciones
{
    public class Fraccion
    {
        int numerador;
        int denominador;

        public Fraccion(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }
        public Fraccion(int numerador) : this(numerador, 1)
        {
        }
        public Fraccion() : this(1, 1)
        {
        }
        public override string ToString()
        {
            return numerador + " / " + denominador;
        }
        public static Fraccion operator +(Fraccion num1, Fraccion num2)
        {
            int multiplo = mcm(num1.denominador, num2.denominador);
            return new Fraccion((multiplo/num1.denominador)*num1.numerador
                + (multiplo/num2.denominador)*num2.numerador,
                multiplo);
           
        }
        public static Fraccion operator -(Fraccion num1, Fraccion num2)
        {
            int multiplo = mcm(num1.denominador, num2.denominador);
            return new Fraccion((multiplo / num1.denominador) * num1.numerador -
                (multiplo / num2.denominador) * num2.numerador,
                multiplo);
        }
        public static Fraccion operator *(Fraccion num1, Fraccion num2)
        {
            Fraccion resultado = new Fraccion(num1.numerador * num2.numerador,
                num1.denominador * num2.denominador);
            return resultado;
        }
        public static Fraccion operator /(Fraccion num1, Fraccion num2)
        {
            Fraccion resultado = new Fraccion(num1.numerador * num2.denominador,
                num1.denominador * num2.numerador);
            return resultado;
        }
        private static int mcm(int num1,int num2)
        {
            bool encontrado = false;
            int contador = num1>num2?num1:num2;
            while(!encontrado)
            {
                if (contador % num1 == 0 && contador % num2 == 0)
                    encontrado = true;
                else
                    contador++;
            }
            return contador;
        }
    }
}
