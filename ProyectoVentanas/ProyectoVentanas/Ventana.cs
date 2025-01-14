using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentanas
{
    internal class Ventana
    {
        int anchura;
        int altura;

        public Ventana(int anchura, int altura)
        {
            this.anchura = anchura;
            this.altura = altura;
        }

        public void SetAnchura(int anchura)
        {
            this.anchura = anchura;
        }

        public int GetAnchura()
        {
            return anchura;
        }

        public void SetAltura(int altura)
        {
            this.altura = altura;
        }

        public int GetAltura()
        {
            return anchura;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Altura: {altura}  Anchura:{anchura}");
        }
    }
}
