using _3300044_es_ES_00_01;

class Program
{
    static void Main()
    {
        // Crear instancias de Cancion
        var cancion1 = new Cancion("Bohemian Rhapsody", "Queen", new TimeSpan(0, 5, 55));

        // Crear instancia de ListaReproduccion
        var playlist = new ListaReproduccion("Clásicos del Rock");

        // Agregar canciones a ListaReproduccion
        playlist.AgregarCancion(cancion1);

        // Mostrar contenido de ListaReproduccion
        playlist.MostrarCanciones();

        // Reproducir una Cancion
        cancion1.Reproducir();
    }
}
