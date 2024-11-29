using PooEnCsharp;

internal class Program
{
    private static void Main(string[] args)
    {
        try { 
            // Instancia de Cancion
            Cancion cancion = new Cancion("Imagine", "John Lennon", 183);

            // Mostrar información de la canción
            cancion.MostrarInformacion();

            Console.WriteLine($"¿Es una canción corta?: {cancion.EsCorta()}");
            Console.WriteLine($"Duración convertida: {cancion.ConvertirDuracionAMinutos()}");

            // Actualizar la duración usando un parámetro
            Console.WriteLine("\nActualizando duración...");
            cancion.ActualizarDuracion(320);

            // Mostrar información actualizada
            cancion.MostrarInformacion();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}