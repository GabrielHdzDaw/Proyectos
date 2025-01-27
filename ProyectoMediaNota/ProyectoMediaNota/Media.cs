using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMediaNota
{
    internal abstract class Media
    {
        string autor;
        int tamanoKB;
        string formato;

        public Media(string autor, int tamanoKB, string formato)
        {
            this.autor = autor;
            this.tamanoKB = tamanoKB;
            this.formato = formato;
        }

        public string GetAutor()
        {
            return autor;
        }

        public int GetTamanoKB()
        { 
            return tamanoKB; 
        }

        public string GetFormato()
        {
            return formato;
        }

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public void SetTamanoKB(int tamanoKB)
        {
            this.tamanoKB = tamanoKB;
        }

        public void SetFormato(string formato)
        {
            this.formato = formato;
        }

        public abstract void Play();

        public override string ToString()
        {
            return $"Autor: {autor}\nTamaño KB: {tamanoKB}\nFormato: {formato}";
        }
    }
}
