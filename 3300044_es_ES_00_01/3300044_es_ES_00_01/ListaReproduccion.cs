using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3300044_es_ES_00_01
{
    internal class ListaReproduccion
    {
        public string Nombre { get; set; }
        private List<Cancion>? canciones = new List<Cancion>(); //Tipos genéricos 2.0

        public ListaReproduccion(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarCancion(Cancion cancion)
        {
            canciones.Add(cancion);
            Console.WriteLine($"Canción '{cancion.Titulo}' añadida a la playlist '{Nombre}'.");
        }

        #region 3.0
        public void MostrarCanciones()
        {
            Console.WriteLine($"\nPlaylist: {Nombre}");
            foreach (var cancion in canciones)
            {
                Console.WriteLine($"- {cancion.Titulo} de {cancion.Artista} ({cancion.Duracion:mm\\:ss})");
            }
        }

        #endregion
        public List<Cancion> ObtenerCancionPorTitulo(string titulo)
        {
            var cancionesConTitulo = canciones.Where(c => c.Titulo == titulo);
            return cancionesConTitulo.ToList<Cancion>();
        }
    }
}
