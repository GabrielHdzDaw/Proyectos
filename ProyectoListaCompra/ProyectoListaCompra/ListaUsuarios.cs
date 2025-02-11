using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListaCompra
{
    internal class ListaUsuarios
    {
        Usuario[] usuarios;
        public ListaUsuarios()
        {
            usuarios = new Usuario[3];
            usuarios[0] = new Usuario("usuario1", "1234");
            usuarios[1] = new Usuario("usuario2", "1234");
            usuarios[2] = new Usuario("usuario3", "1234");
        }

        public bool EsValido(string nombre, string contrasena)
        {
            bool valido = false;
            foreach (Usuario usuario in usuarios)
            {
                valido = usuario.GetNombre() == nombre && usuario.GetContrasena() == contrasena;
            }
            return valido;
        }

        public Usuario[] GetUsuarios()
        {
            return usuarios;
        }

        public void SetUsuarios(Usuario[] usuarios)
        {
            this.usuarios = usuarios;
        }


    }
}
