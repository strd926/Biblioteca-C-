using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    internal class Miembro
    {
        public string Nombre { get; set; }
        public int NumeroMiembro { get; set; }
        public List<Prestamo> HistorialPrestamos { get; private set; }

        public Miembro(string nombre, int numeroMiembro)
        {
            Nombre = nombre;
            NumeroMiembro = numeroMiembro;
            HistorialPrestamos = new List<Prestamo>();
        }
    }
}
