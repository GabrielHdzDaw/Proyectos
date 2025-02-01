using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorInstituto
{
    internal class Alumno:Persona
    {
        Random generator = new Random();
        string[] tareasRandom =
        {
            "Vagueando",
            "Instagram",
            "WhatsApp",
            "Facebook",
            "Twitter",
            "Snapchat",
            "TikTok",
            "Queriendo morirse",
            "Vandalizando",
            "Jugando a videojuegos",
            "Haciendo deporte",
            "Viendo series",
            "\"Estudiando\"",
            "¡Es increíble! ¡Está estudiando de verdad!"
        };

        string tareaActual;
        DateTime horaDespertar;
        bool despierto;

        Aula aulaObj;
        int aula;

        public Alumno(string nombre, int edad, int aula) : base(nombre, edad)
        {
            this.aula = aula;
            horaDespertar = new DateTime(1, 1, 1, 6, generator.Next(0, 4) * 15, 0);
            despierto = false;
        }

        public Alumno(Aula aulaObj):this("alumno", 0, 0)
        {
            this.aulaObj = aulaObj;
            horaDespertar = new DateTime(1, 1, 1, 6, generator.Next(0, 4) * 15, 0);
            despierto = false;
        }

        public int GetAula()
        {
            return aula;
        }

        public void SetAula(int aula)
        {
            this.aula = aula;
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

        public override string ToString()
        {
            return base.ToString() + $"Aula: {aula}";
        }
    }
}
