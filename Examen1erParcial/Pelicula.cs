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
        public string Sipnosis { get; set; }

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

        private float _rating;
        public float Rating
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
            Sipnosis = "Sin Sipnosis";
        }

        public Pelicula(string titulo, string director, string genero, string pais, string sipnosis)
        {
            Titulo = titulo;
            Director = director;
            Genero = genero;
            Pais = pais;
            Sipnosis = sipnosis;
        }

        public Pelicula(string titulo, int año)
        {
            Titulo = titulo;
            Año = año;
        }
    }
}
