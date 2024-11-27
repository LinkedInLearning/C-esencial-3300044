using System;

internal class Program
{
    public record Cancion (string Titulo, string Artista, TimeSpan Duracion);
    private static void Main(string[] args)
    {
        #region Tipo record
        var cancion = new Cancion("Bohemian Rhapsody", "Queen", new TimeSpan(0, 5, 55));
        //Console.WriteLine($"{}");

        var cancion2 = cancion with { Duracion = new TimeSpan(0, 5, 58) };

        var cancion3 = new Cancion("Bohemian Rhapsody", "Queen", new TimeSpan(0, 5, 55));
        if (cancion == cancion3)
        {
            Console.WriteLine($"Son iguales!");
        }

        var (titulo, artista, tiempo) = cancion;
        Console.WriteLine($"{tiempo}");

        #endregion

    }
}