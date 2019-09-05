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

            uno.Peliculas.Add(new Pelicula("Gato con botas", 2004, "Pepe", "Infantil", "Mex", "Divertida", 90, 9.8)); 
            uno.Peliculas.Add(new Pelicula("Pinocho", 2006, "Alex C.", "Infantil", "Eu", "Divertida", 80, 8));
            uno.Peliculas.Add(new Pelicula("Caperucita Roja", 2008, "Daniel L.", "Infantil", "Mex", "Divertida", 80, 8));
            uno.Peliculas.Add(new Pelicula("Cenicienta", 2014, "Pepe", "Infantil", "Mex", "Divertida", 80, 8));
            uno.Peliculas.Add(new Pelicula("Blaca Nieves", 2015, "Pedro", "Infantil", "X", "Divertida", 80, 8));
            uno.Peliculas.Add(new Pelicula("Lala", 1900, "Pepe", "Infantil", "Mex", "Divertida", 80, 8));
            uno.Peliculas.Add(new Pelicula("Hachi", 2019, "Pepe", "Infantil", "Mex", "Divertida", 80, 8));

            Playlist dos = new Playlist("Dos");

            dos.Descripcion = "Terror";

            dos.Peliculas.Add(new Pelicula("Child's Play", 1988, "Pepe", "Terros psicológico", "Eu", "Horror", 80, 8));
            dos.Peliculas.Add(new Pelicula("Child's Play 2", 1990, "Pepe", "Terros psicológico", "Eu", "Horror", 80, 8));
            dos.Peliculas.Add(new Pelicula("Scream", 1980, "Pepe", "Terros psicológico", "Eu", "Horror", 80, 8));
            dos.Peliculas.Add(new Pelicula("Viernes 13", 1982, "Pepe", "Terros psicológico", "Eu", "Horror", 80, 8));
            dos.Peliculas.Add(new Pelicula("Mamá", 2004, "Pepe", "Terros psicológico", "Eu", "Horror", 80, 8));
            dos.Peliculas.Add(new Pelicula("See you", 2013, "Pepe", "Terros psicológico", "Eu", "Horror", 80, 8));
            dos.Peliculas.Add(new Pelicula("El niño", 2017, "Pepe", "Terros psicológico", "Eu", "Horror", 80, 8));

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
