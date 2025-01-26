using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSpaceInvaders
{
    internal class Sprite
    {
        protected int x;
        protected int y;
        protected string imagen;

        public Sprite(int x, int y, string imagen)
        {
            Console.WriteLine("Creando sprite");
            this.x = x;
            this.y = y;
            this.imagen = imagen;
        }
        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetX()
        {
            return this.x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetY()
        {
            return this.y;
        }

        public void SetImagen(string imagen)
        {
            this.imagen = imagen;
        }

        public string GetImagen()
        {
            return imagen;
        }

        public void MoverA(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Dibujar()
        {
            Console.SetCursorPosition(x / 12, y / 30);
            Console.Write(imagen);
        }
    }
}
