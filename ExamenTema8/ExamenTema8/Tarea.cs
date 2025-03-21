using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema8
{
    internal class Tarea: IComparable<Tarea>
    {
        protected string descripcion;
        protected bool realizada;

        public Tarea(string descripcion, bool realizada)
        {
            this.descripcion = descripcion;
            this.realizada = realizada;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public bool GetRealizada()
        {
            return realizada;
        }

        public void SetDescripcion(string descripcion)
        {
            this.descripcion= descripcion;
        }

        public void Realizar()
        {
            realizada = true;
        }

        public int CompareTo(Tarea tarea)
        {
            if(tarea == null)
            {
                return -1;
            }
            return descripcion.CompareTo(tarea.GetDescripcion());
        }

        public override string ToString()
        {
            return $"Descripción: {descripcion} -- {(realizada ? "Realizada" :  "No realizada")}";
        }
    }
}
