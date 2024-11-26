using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3300044_es_ES_00_01
{
    internal class Cancion
    {
        public string Titulo { get; set; } 
        public string Artista { get; set; }
        public TimeSpan Duracion { get; set; }

        public Cancion(string titulo, string artista, TimeSpan duracion)
        {
            Titulo = titulo;
            Artista = artista;
            Duracion = duracion;
        }

        public async Task Reproducir()
        {
            await Task.Delay(2000);
            Console.WriteLine($"Reproduciendo '{Titulo}' de {Artista}... ({Duracion:mm\\:ss})"); //6.0 interpolación
        }
    }
}
