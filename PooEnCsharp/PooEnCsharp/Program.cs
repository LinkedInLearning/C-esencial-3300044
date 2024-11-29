using PooEnCsharp;

internal class Program
{
    private static void Main(string[] args)
    {
        try {
            // Crear una lista de reproducción 
            ListaReproduccion listaGeneral = new ListaReproduccion("Mis Canciones");
            listaGeneral.AgregarCancion("Imagine");
            listaGeneral.AgregarCancion("Let It Be");
            listaGeneral.AgregarCancion("Bohemian Rhapsody");

            // Crear una lista de reproducción de favoritos
            ListaFavoritos listaFavoritos = new ListaFavoritos("Favoritos del Rock");
            listaFavoritos.AgregarCancion("Stairway to Heaven");
            listaFavoritos.AgregarCancion("Hotel California");
            listaFavoritos.AgregarCancion("Smoke on the Water");

            // Marcar canciones como favoritas
            listaFavoritos.MarcarComoFavorita("Stairway to Heaven");
            listaFavoritos.MarcarComoFavorita("Hotel California");

            // Mostrar toda la información de las listas
            Console.WriteLine();
            listaFavoritos.MostrarTodo(); // Método específico de la clase derivada
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}