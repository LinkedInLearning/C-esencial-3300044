using PooEnCsharp;

internal class Program
{
    private static void Main(string[] args)
    {
        try {
            // canción de constructor por defecto
            Cancion cancionDef = new Cancion();
            cancionDef.MostrarInformacion();


            // Instancia de Cancion - sobrecarga de constructor
            Cancion cancion = new Cancion("Imagine", "John Lennon", 183);
            cancion.MostrarInformacion();

            // Usando el deconstructor
            Console.WriteLine("\nDesempaquetando la canción...");
            var (titulo, artista, duracion) = cancion;
            Console.WriteLine($"Título: {titulo}, Artista: {artista}, Duración: {duracion} segundos");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}