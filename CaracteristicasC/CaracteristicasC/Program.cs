using CaracteristicasC;

class Program
{

    public record Artista (string Nombre, string Pais);

    #region 12.0
    public record Artista12
    {
        public string Nombre { get; init; } = "Desconocido";
        public string Pais { get; init; } = "Desconocido";
    }

   
    public record Album (double duracion)
    {
        public double Duracion => duracion + 2;
    }
    #endregion
    
    static void Main()
    {

        var cancion1 = new Cancion("Bohemian Rhapsody", "Queen", new TimeSpan(0, 5, 55));

        var playlist = new ListaReproduccion("Clásicos del Rock");

        #region 7.0
        int totalCanciones = default;
        TimeSpan duracionTotal = default;
        #endregion

        #region 8.0
        string? tituloCancion = null;
        Console.WriteLine(tituloCancion?.Length ?? 0);
        #endregion

        #region 9.0
        var artista1 = new Artista("Queen", "Reino Unido");
        var artista2 = new Artista("Aerosmith", "EUA");
        var artista3 = new Artista("Aerosmith", "EUA");

        Console.WriteLine(artista2 == artista3);

        var (nombre, pais) = artista1;
        Console.WriteLine(nombre);

        #endregion
    }
}
