using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    internal class LibroFisico : Libro
    {
        private string Ubicacion {  get; set; }

        public LibroFisico(string titulo, string autor, int anioPublicacion, string ubicacion)
            : base(titulo, autor, anioPublicacion)
        {
            Ubicacion = ubicacion;
        }

        public override string ObtenerDetalles()
        {
            return $"{titulo} - {autor} (Fisico), publicado en {anioPublicacion}, Ubicacion: {Ubicacion}";
        }
    }
}
