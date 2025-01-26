using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCoches
{
    internal class Vehiculo
    {
        protected string marca;
        protected string modelo;
        protected int cilindrada;
        protected double potencia;
        protected int cantidadRuedas;
        int velocidad;


        public Vehiculo(string marca, string modelo, int cilindrada, double potencia, int cantidadRuedas)
        {
            Console.WriteLine("Constructor vehículo");
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.potencia = potencia;
            this.cantidadRuedas = cantidadRuedas;
        }
        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public int GetCilindrada()
        {
            return cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }

        public double GetPotencia()
        {
            return potencia;
        }

        public void SetPotencia(double potencia)
        {
            this.potencia = potencia;
        }

        public int GetCantidadRuedas()
        {
            return cantidadRuedas;
        }

        public void SetCantidadRuedas(int cantidadRuedas)
        {
            this.cantidadRuedas = cantidadRuedas;
        }

        public void Circular()
        {
            velocidad = 50;
        }
        public void Circular(int velocidad)
        {
            this.velocidad = velocidad;
        }

        public override string ToString()
        {
            return $"Marca: {marca}\nModelo: {modelo}\nPotencia: {potencia}\nCilindrada: {cilindrada}\nNº ruedas: {cantidadRuedas}";
        }
    }
}
