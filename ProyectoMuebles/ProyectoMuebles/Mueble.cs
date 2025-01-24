using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuebles
{
    internal abstract class Mueble
    {
        protected int anchura;
        protected int altura;
        protected string material;

        public Mueble(int anchura, int altura, string material)
        {
            this.anchura = anchura;
            this.altura = altura;
            this.material = material;
        }

        public int GetAnchura()
        {
            return anchura;
        }
        public void SetAnchura(int anchura)
        {
            this.anchura = anchura;
        }

        public int GetAltura()
        {
            return altura;
        }

        public void SetAltura(int altura)
        {
            this.altura = altura;
        }

        public string GetMaterial()
        {
            return material;
        }

        public void SetMaterial(string material)
        {
            this.material = material;
        }

        public override string ToString()
        {
            return $"{anchura} - {altura} - {material}";
        }
    }
}
