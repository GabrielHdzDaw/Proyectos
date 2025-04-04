using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{

    internal class FileSystemInfoData
    {
        string nombre;
        bool esDirectorio;
        int longitud;
        DateTime fechaModificacion;

        public FileSystemInfoData(string nombre, bool esDirectorio, int longitud, DateTime fechaModificacion)
        {
            this.nombre = nombre;
            this.esDirectorio = esDirectorio;
            this.longitud = longitud;
            this.fechaModificacion = fechaModificacion;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool EsDirectorio
        {
            get { return esDirectorio; }
            set { esDirectorio = value; }
        }

        public int Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, EsDirectorio: {esDirectorio}, Longitud: {longitud}, FechaModificacion: {fechaModificacion}";
        }


    }
}
