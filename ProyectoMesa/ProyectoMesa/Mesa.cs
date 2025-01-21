using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMesa
{
    internal class Mesa
    {
        Pata pata;
        string material;
        float altura;
        float anchura;

        public Mesa(float altura, float anchura)
        {
            pata = new Pata();
            material = "";
            this.altura = altura;
            this.anchura = anchura;
            anchura = 0;
            Console.WriteLine("Creando mesa");
        }

        

        public Mesa() : this(0, 0)
        {
        }

        public void SetPata(Pata pata)
        {
            this.pata = pata;
        }

        public void SetMaterial(string material)
        {
            this.material = material;
        }

        public void SetAltura(float altura)
        {
            this.altura = altura;
        }
        public void SetAnchura(float anchura)
        {
            this.anchura = anchura;
        }

        public Pata GetPata()
        {
            return pata;
        }

        public string GetMaterial()
        {
            return material;
        }

        public float GetAltura()
        {
            return altura;
        }

        public float GetAnchura()
        {
            return anchura;
        }

        public override string ToString()
        {
            return $"Mesa de {material}, {altura} x {anchura}, con patas{pata}";
        }
    }
}
