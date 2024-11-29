using PooEnCsharp;

internal class Program
{
    private static void Main(string[] args)
    {
        // Instancia de Cancion
        Cancion cancion = new Cancion("Imagine", "John Lennon", 183);
        Cancion cancionFav = new Cancion("Crazy", "Aerosmith", 185);

        // Mostrar información de la canción
        cancion.MostrarInformacion();
    }
}