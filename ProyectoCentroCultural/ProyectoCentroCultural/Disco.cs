using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCentroCultural
{
    internal class Disco:Material
    {
        string discografia;

        public Disco(int codigo, string titulo, string autor, string discografia) : base(codigo, titulo, autor)
        {
            this.discografia = discografia;
        }

        public string GetDiscografia()
        {
            return discografia;
        }

        public void SetDiscografia(string discografia)
        {
            this.discografia = discografia;
        }

        public override string ToString()
        {
            return base.ToString() + $", Discografía: {discografia}";
        }
    }
}
