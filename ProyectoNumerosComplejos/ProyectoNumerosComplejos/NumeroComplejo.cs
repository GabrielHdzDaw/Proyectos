using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNumerosComplejos
{
    internal class NumeroComplejo
    {
        double real;
        double imaginario;

        public NumeroComplejo(double real, double imaginario)
        {
            this.real = real;
            this.imaginario = imaginario;
        }

        public NumeroComplejo() : this(0, 0)
        {

        }

        public void SetReal(double real)
        {
            this.real = real;
        }

        public double GetReal()
        {
            return real;
        }

        public void SetImaginario(double imaginario)
        {
            this.imaginario = imaginario;
        }

        public double GetImaginario()
        {
            return imaginario;
        }

        public double GetMagnitud()
        {
            return Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginario, 2));
        }

        public static NumeroComplejo Suma(NumeroComplejo numero1, NumeroComplejo numero2)
        {
            return new NumeroComplejo(numero1.GetReal() + numero2.GetReal(), numero1.GetImaginario() + numero2.GetImaginario());
        }

        public static NumeroComplejo operator +(NumeroComplejo numero1, NumeroComplejo numero2)
        {
            return NumeroComplejo.Suma(numero1, numero2);
        }

        public override string ToString()
        {
            char signo = imaginario >= 0 ? '+' : '-';
            return $"{real} {signo} {imaginario}i";
        }

    }
}
