using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string Pais { get; set; }
        public string Sinopsis { get; set; }

        private int _año;
        public int Año
        {
            get
            {
                return _año;
            }
            set
            {
                if (value >= 1800 && value <= 2019)
                {
                    _año = value;
                }
                else
                {
                    throw new Exception("El año debe ser de 1800 a 2019");
                }
            }
        }

        private int _duracion;
        public int Duracion
        {
            get
            {
                return _duracion;
            }
            set
            {
                if (value >= 0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("El número debe ser mayor a 0");
                }
            }
        }

        private double _rating;
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("El numero debe ser del 0 al 10");
                }
            }
        }

        public Pelicula()
        {
            Titulo = "Sin Título";
            Director = "Sin Director";
            Genero = "Sin Asignar";
            Pais = "Sin País";
            Sinopsis = "Sin Sipnosis";
        }

        public Pelicula(string titulo, string director, string genero, string pais, string sipnosis)
        {
            Titulo = titulo;
            Director = director;
            Genero = genero;
            Pais = pais;
            Sinopsis = sipnosis;
        }

        public Pelicula(string titulo, int año)
        {
            Titulo = titulo;
            Año = año;
        }

        public Pelicula(string titulo,int año, string director, string genero, string pais, string sinopsis, int duracion, double rating)
        {
            Titulo = titulo;
            Año = año;
            Director = director;
            Genero = genero;
            Pais = pais;
            Sinopsis = sinopsis;
            Duracion = duracion;
            Rating = rating;
        }
    }
}
