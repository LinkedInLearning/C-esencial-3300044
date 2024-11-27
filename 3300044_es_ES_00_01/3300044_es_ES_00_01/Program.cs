using _3300044_es_ES_00_01;

class Program
{
    /// <summary>
    /// Este es mi método principal
    /// </summary>
    static void Main()
    {

        var cancion1 = new Cancion("Bohemian Rhapsody", "Queen", new TimeSpan(0, 5, 55));

        var playlist = new ListaReproduccion("Clásicos del Rock");

        playlist.AgregarCancion(cancion1);
  
        playlist.MostrarCanciones();
         

        cancion1.Reproducir();
    }
}
