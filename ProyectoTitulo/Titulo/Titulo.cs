using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppTest
{
    public class Titulo
    {
        protected string texto;
        protected int x;
        protected int y;

        public Titulo(string texto, int x, int y)
        {
            this.texto = texto;
            this.x = x;
            this.y = y;
        }

        public Titulo(string texto)
        {
            this.texto = texto;
            this.x = 36;
            this.y = 5;
        }

        public Titulo()
        {
            texto = "Welcome";
            x = 36;
            y = 5;
        }

        public string GetTexto()
        {
            return texto;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void SetTexto(string texto)
        {
            this.texto = texto;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public virtual void Mostrar()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(texto);
        }
    }
}