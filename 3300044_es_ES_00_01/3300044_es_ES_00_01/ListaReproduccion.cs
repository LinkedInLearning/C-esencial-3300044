using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3300044_es_ES_00_01
{
    /// <summary>
    /// Esta es una clase relacionada a las listas de Reproducción
    /// </summary>
    internal class ListaReproduccion
    {
        public string Nombre { get; set; }
        private List<Cancion>? Canciones = new List<Cancion>();

        public ListaReproduccion(string nombre)
        {
            Nombre = nombre;
        }

        /// <summary>
        /// Este método permite agregar una canción a la lista de reproducción
        /// </summary>
        /// <param name="cancion"> elemento canción que se quiere agregar a la lista</param>
        /// 

        // TODO: Implementar el manejo de errores
        public void AgregarCancion(Cancion cancion)
        {
            Canciones.Add(cancion);
            Console.WriteLine($"Canción '{cancion.Titulo}' añadida a la playlist '{Nombre}'.");
        }

        public void MostrarCanciones()
        {
            Console.WriteLine($"\nPlaylist: {Nombre}");
            foreach (var cancion in Canciones)
            {
                Console.WriteLine($"- {cancion.Titulo} de {cancion.Artista} ({cancion.Duracion:mm\\:ss})");
            }
        }

        #region 7.0
        public List<Cancion> ObtenerCancionPorTitulo(string? titulo)
        {
            _ = titulo ?? throw new ArgumentNullException(nameof(titulo), "El título de la canción no puede ser nulo.");
            var cancionesConTitulo = Canciones.Where(c => c.Titulo == titulo);
            return cancionesConTitulo.ToList<Cancion>();
        }
        #endregion
    }
}
