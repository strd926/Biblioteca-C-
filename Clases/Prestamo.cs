using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    internal class Prestamo
    {
        public Libro Libro { get; set;}
        public Miembro Miembro { get; set;}
        public DateTime FechaPrestamo { get; set;}
        public DateTime FechaDevolucion {  get; set;}

        public Prestamo (Libro libro , Miembro miembro)
        {
            Libro = libro;
            Miembro = miembro;
            FechaPrestamo = DateTime.Now;
            DateTime dateTime = FechaPrestamo.AddDays(10);
            FechaDevolucion = dateTime;
        }

        public string RealizarPrestamo()
        {
            Miembro.HistorialPrestamos.Add(this);
            return $"{Miembro.Nombre} ha tomado prestado '{Libro.Titulo}' el {FechaPrestamo.ToShortDateString()} Devolucion: {FechaDevolucion.ToShortDateString()}";
        }
    }
}
