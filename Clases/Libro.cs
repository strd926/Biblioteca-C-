using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    internal abstract class Libro
    {
        public string titulo;
        public string autor;
        public int anioPublicacion;
        public bool prestado;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
          get { return autor; }
          set { autor = value; } 
        }

        public int AnioPublicacion
        { 
          get { return anioPublicacion; } 
          set { anioPublicacion = value; } 
        }

        public Libro(string titulo, string autor, int anioPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
        }
        public abstract string ObtenerDetalles();

    }
}
