﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3300044_es_ES_00_01
{
    internal class Cancion
    {
        public string Titulo { get; set; }  // Propiedad con tipo fuerte
        public string Artista { get; set; }
        public TimeSpan Duracion { get; set; }

        public Cancion(string titulo, string artista, TimeSpan duracion)
        {
            Titulo = titulo;
            Artista = artista;
            Duracion = duracion;
        }

        public void Reproducir()
        {
            Console.WriteLine($"Reproduciendo '{Titulo}' de {Artista}... ({Duracion:mm\\:ss})");
        }
    }
}
