

namespace ProyectoSpaceInvaders
{
    internal class Juego
    {
        public void Lanzar()
        {
            
            Bienvenida bienvenida = new Bienvenida();
            Partida partida = new Partida();
            while (!bienvenida.GetSalir())
            {
                bienvenida.Lanzar();
                if (!bienvenida.GetSalir())
                {
                    partida.Lanzar();
                }
            }
        }
    }
}
