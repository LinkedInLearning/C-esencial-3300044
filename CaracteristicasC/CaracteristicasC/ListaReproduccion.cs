
namespace CaracteristicasC
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

        public void MostrarCanciones()
        {
            Console.WriteLine($"\nPlaylist: {Nombre}");
            foreach (var cancion in canciones)
            {
                Console.WriteLine($"- {cancion.Titulo} de {cancion.Artista} ({cancion.Duracion:mm\\:ss})");
            }
        }

        #region 7.0
        public List<Cancion> ObtenerCancionPorTitulo(string? titulo)
        {
            _ = titulo ?? throw new ArgumentNullException(nameof(titulo), "El título de la canción no puede ser nulo.");
            var cancionesConTitulo = canciones.Where(c => c.Titulo == titulo);
            return cancionesConTitulo.ToList<Cancion>();
        }
        #endregion
    }
}
