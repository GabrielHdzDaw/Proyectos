using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCentroCultural
{
    internal abstract class Material
    {
        int codigo;
        string titulo;
        string autor;

        public Material(int codigo, string titulo, string autor)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.autor = autor;
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public string GetAutor()
        {
            return autor;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public override string ToString()
        {
            return $"Código: {codigo}, Título: {titulo}, Autor: {autor}";
        }
    }
}
