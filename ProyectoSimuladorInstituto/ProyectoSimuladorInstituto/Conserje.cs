using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorInstituto
{
    internal class Conserje: Persona
    {
        Random generator = new Random();
        string[] tareasRandomTrabajo =
        { 
            
            "Limpiando el suelo",
            "Echando broncas a los alumnos",
            "Revisando que no haya alumnos en los baños",
            "Revisando que no haya alumnos en los pasillos",
            "Revisando que no haya alumnos en el patio",
            "Vigilando la salida de los alumnos",
        };

        string[] tareasRandom =
        {
            "Vagueando",
            "Discutiendo con la mujer",
            "Metiendo barcos en botellas",
            "Imaginando una vida mejor",
            "TikTok",
            "Haciendo deporte",
            "Viendo series"
        };

        string tareaActual;
        DateTime horaDespertar;
        bool despierto;
        public Conserje(string nombre, int edad) : base(nombre, edad)
        {
            horaDespertar = new DateTime(1, 1, 1, 6, generator.Next(0, 4) * 15, 0);
            despierto = false;
        }

        public override void MostrarEstado()
        {

            Console.WriteLine($"{GetNombre()}: {tareaActual}");
        }

        public override void Animar15minutos(DateTime fecha)
        {
            if (!despierto && fecha.Hour == horaDespertar.Hour && fecha.Minute == horaDespertar.Minute)
            {
                tareaActual = "Despertándose";
                despierto = true;
            }
            else if (despierto && fecha.Hour >= 7 && fecha.Hour < 8)
            {
                tareaActual = "Yendo al instituto";
            }
            else if (despierto && fecha.Hour >= 8 && fecha.Hour < 15)
            {
                tareaActual = tareasRandomTrabajo[generator.Next(0, tareasRandomTrabajo.Length)];
            }
            else if (despierto && fecha.Hour >= 15 && fecha.Hour < 16)
            {
                tareaActual = "Volviendo a casa";
            }
            else if (despierto && fecha.Hour >= 16 && fecha.Hour < 23)
            {
                tareaActual = tareasRandom[generator.Next(0, tareasRandom.Length)];
            }
            else if (!despierto || (despierto && fecha.Hour >= 23))
            {
                tareaActual = "Durmiendo";
                despierto = false;
            }
        }
    }
}
