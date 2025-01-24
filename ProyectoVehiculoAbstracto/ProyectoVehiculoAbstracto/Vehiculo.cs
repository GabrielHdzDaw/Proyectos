using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVehiculoAbstracto
{
    internal abstract class Vehiculo
    {
        protected string marca;
        protected string modelo;
        protected string color;
        protected int potencia;
        protected int ruedas;
        protected int peso;
        
        public Vehiculo(string marca, string modelo, string color, int potencia, int peso, int ruedas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.potencia = potencia;
            this.ruedas = ruedas;
            this.peso = peso;
        }

        public Vehiculo() : this("","","",0, 0, 0) { }

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

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public int GetPotencia()
        {
            return potencia;
        }
        
        public void SetPotencia(int potencia)
        {
            this.potencia = potencia;
        }

        public int GetRuedas()
        {
            return ruedas;
        }

        public void SetRuedas(int ruedas)
        {
            this.ruedas = ruedas;
        }

        public int GetPeso()
        {
            return peso;
        }

        public void SetPeso(int peso)
        {
            this.peso = peso;
        }

        public abstract void Acelerar();
        public abstract void Frenar();

        public override string ToString()
        {
            return $"Marca: {marca}\nModelo: {modelo}\nColor: {color}\nPotencia: {potencia} cv" +
                $"\nPeso: {peso} kg\nNº ruedas: {ruedas}";
        }
    }
}
