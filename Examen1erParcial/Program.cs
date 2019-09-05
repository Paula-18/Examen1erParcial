using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();

            Playlist uno = new Playlist("Uno");

            uno.Descripcion = "Para ver en familia";

            uno.Peliculas.Add(new Pelicula("Gato con botas", 2004));
            uno.Peliculas.Add(new Pelicula("Pinocho", 2006));
            uno.Peliculas.Add(new Pelicula("Caperucita Roja", 2008));
            uno.Peliculas.Add(new Pelicula("Cenicienta", 2014));
            uno.Peliculas.Add(new Pelicula("Blaca Nieves", 2015));
            uno.Peliculas.Add(new Pelicula("Lala", 1900));
            uno.Peliculas.Add(new Pelicula("Hachi", 2019));

            Playlist dos = new Playlist("Dos");

            dos.Descripcion = "Terror";

            dos.Peliculas.Add(new Pelicula("Child's Play", 1988));
            dos.Peliculas.Add(new Pelicula("Child's Play 2", 1990));
            dos.Peliculas.Add(new Pelicula("Scream", 1980));
            dos.Peliculas.Add(new Pelicula("Viernes 13", 1982));
            dos.Peliculas.Add(new Pelicula("Mamá", 2004));
            dos.Peliculas.Add(new Pelicula("See you", 2013));
            dos.Peliculas.Add(new Pelicula("El niño", 2017));

            playlists.Add(uno);
            playlists.Add(dos);

            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine("Lista: " + playlist.Titulo + " Descripción:  " + playlist.Descripcion);
                Console.WriteLine("Lista de los peliculas: ");
                foreach (Pelicula pelicula in playlist.Peliculas)
                {
                    Console.WriteLine("*" + pelicula.Titulo + " " + pelicula.Año);
                }
            }

            Console.Read();
        }
    }
}
