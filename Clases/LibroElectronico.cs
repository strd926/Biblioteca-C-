using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    internal class LibroElectronico : Libro
    { 
        public double TamanioArchivo {  get; set; }
        public string Formato { get; set; }

        public LibroElectronico(string titulo, string autor, int anioPublicacion, double tamanioArchivo, string formato) 
            :base (titulo, autor, anioPublicacion)
        {
            TamanioArchivo = tamanioArchivo;
            Formato = formato;
        }

        public override string ObtenerDetalles()
        {
            return $"{titulo} - {autor} (Electronico), Publicado en {AnioPublicacion}, Tamaño:{TamanioArchivo}MB, Formato: {Formato}";
        }

    }
}
