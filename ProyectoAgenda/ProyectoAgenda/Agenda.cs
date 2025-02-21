using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda
{
    internal class Agenda
    {
        List<Contacto> contactos;
        List<Reunion> reuniones;

        public Agenda()
        {
            contactos = new List<Contacto>()
            {
                new Contacto("Juan", "CEO", "Empresa1"),
                new Contacto("Ana", "CTO", "Empresa2"),
                new Contacto("Luis", "CFO", "Empresa3"),
                new Contacto("Maria", "CMO", "Empresa4"),
                new Contacto("Pedro", "CIO", "Empresa5"),
            };
            reuniones = new List<Reunion>()
            {
                new Reunion("Reunion1", new DateTime(2021, 1, 1, 10, 0, 0), contactos[0]),
                new Reunion("Reunion2", new DateTime(2021, 1, 2, 10, 0, 0), contactos[1]),
                new Reunion("Reunion3", new DateTime(2021, 1, 3, 10, 0, 0), contactos[2]),
                new Reunion("Reunion4", new DateTime(2021, 1, 4, 10, 0, 0), contactos[3]),
                new Reunion("Reunion5", new DateTime(2021, 1, 5, 10, 0, 0), contactos[4]),
            };
        }

        public void MostrarReunionesOrdenadas()
        {
            reuniones.Sort();
            reuniones.ForEach(reunion => Console.WriteLine(reunion));
        }

        public void VerReunionesHoy()
        {
            DateTime hoy = DateTime.Now;
            List<Reunion> reunionesHoy = reuniones.FindAll(reunion => reunion.GetFechaHora().Date == hoy.Date);
            reunionesHoy.ForEach(reunion => Console.WriteLine(reunion));
        }

        public void MostrarReunionesProximaSemana()
        {
            DateTime hoy = DateTime.Now;
            DateTime proximaSemana = hoy.AddDays(7);
            List<Reunion> reunionesProximaSemana = reuniones.FindAll(reunion => reunion.GetFechaHora().Date >= hoy.Date && reunion.GetFechaHora().Date <= proximaSemana.Date);
            reunionesProximaSemana.ForEach(reunion => Console.WriteLine(reunion));
        }

        public void MostrarContactosOrdenados()
        {
            contactos.Sort();
            Console.WriteLine("Ordenados por nombre: ");
            contactos.ForEach(contacto => Console.WriteLine(contacto));
            contactos.Sort((contacto1, contacto2) => contacto1.GetEmpresa().CompareTo(contacto2.GetEmpresa()));
            Console.WriteLine("Ordenados por emresa: ");
            contactos.ForEach(contacto => Console.WriteLine(contacto));
        }

        public void AnadirReunion()
        {
            Console.Write("Introduce nombre de la reunión: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce fecha y hora de la reunión (dd/mm/yyyy hh:mm): ");
            DateTime fechaHora = DateTime.Parse(Console.ReadLine());
            Console.Write("Introduce nombre del contacto: ");
            string nombreContacto = Console.ReadLine();
            Contacto contacto = contactos.Find(contacto => contacto.GetNombre() == nombreContacto);
            if (contacto == null)
            {
                Console.WriteLine("Contacto no encontrado");
                return;
            }
            Reunion reunion = new Reunion(nombre, fechaHora, contacto);
            reuniones.Add(reunion);
            Console.WriteLine($"Reunión añadida: {reunion}");
        }

        public void BorrarReunion()
        {
            Console.Write("Introduce nombre de la reunión a borrar: ");
            string nombre = Console.ReadLine();
            Reunion reunion = reuniones.Find(reunion => reunion.GetNombre() == nombre);
            if (reunion == null)
            {
                Console.WriteLine("Reunión no encontrada");
                return;
            }
            else
            {
                reuniones.Remove(reunion);
                Console.WriteLine($"Reunión borrada: {reunion}");
            }
        }

        public void MoverReuniones1Dia()
        {
            
            reuniones.ForEach(reunion => reunion.SetFechaHora(reunion.GetFechaHora().AddDays(1)));
            Console.WriteLine("Reuniones movidas 1 día");
        }

        public void MostrarContactosEmpresa()
        {
            Console.WriteLine();
            List<Contacto> contactosEmpresa = contactos.FindAll(contacto => contacto.GetEmpresa() == empresa);
            contactosEmpresa.ForEach(contacto => Console.WriteLine(contacto));
        }
    }
}
