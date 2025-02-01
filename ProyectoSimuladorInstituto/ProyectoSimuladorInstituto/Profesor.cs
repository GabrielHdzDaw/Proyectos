using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorInstituto
{
    internal class Profesor: Persona
    {
        Random generator = new Random();
        string[] tareasRandom =
        {
            "Vagueando",
            "Corrigiendo exámenes",
            "Preparando la clase",
            "Revisando ejercicios",
            "Respondiendo dudas",
            "Haciendo cosas de profesores"

        };
        DateTime horaDespertar;
        bool despierto;
        string tareaActual;
        public Profesor(string nombre, int edad) : base(nombre, edad)
        {
            horaDespertar = new DateTime(1, 1, 1, 6, generator.Next(0, 4) * 15, 0);
            despierto = false;
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
                tareaActual = "En clase";
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

        public override void MostrarEstado()
        {

            Console.WriteLine($"{GetNombre()}: {tareaActual}");
        }
    }
}
