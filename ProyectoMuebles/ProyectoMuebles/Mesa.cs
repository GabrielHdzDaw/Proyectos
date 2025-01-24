using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuebles
{
    internal class Mesa:Mueble
    {
        string materialPatas;

        public Mesa(int anchura, int altura, string material, string materialPatas) :base(anchura, altura, material)
        {
            this.materialPatas = materialPatas;
        }

        public string GetMaterialPatas()
        {
            return materialPatas;
        }

        public void SetMaterialPatas(string materialPatas)
        {
            this.materialPatas = materialPatas; 
        }

        public override string ToString()
        {
            return base.ToString() + $" - {materialPatas}";
        }
    }
}
