using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Playlist
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Pelicula> Peliculas { get; set; }

        public Playlist()
        {
            Titulo = "Sin Título";
            Descripcion = "Sin Descripción";
            Peliculas = new List<Pelicula>();
        }

        public Playlist(string titulo)
        {
            Titulo = titulo;
            Descripcion = "Sin Descripción";
            Peliculas = new List<Pelicula>();
        }

        public Playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Peliculas = new List<Pelicula>();
        }
    }
}
