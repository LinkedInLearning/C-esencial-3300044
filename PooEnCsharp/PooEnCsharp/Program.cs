using PooEnCsharp;

internal class Program
{
    private static void Main(string[] args)
    {
        try {
            // Instancia de Cancion - sobrecarga de constructor
            Cancion cancion = new Cancion("Imagine", "John Lennon", 183);

            // Acceso a método público
            cancion.MostrarInformacion();

            // Acceso a método interno
            cancion.ActualizarDuracion(200);
            // Mostrar información actualizada
            cancion.MostrarInformacion();

            //Acceso a método protegido ConvertirDuración NO es posible
            //cancion.ConvertirDuracionAMinutos(200);

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}