using PooEnCsharp;

internal class Program
{
    private static void Main(string[] args)
    {
        try {
            // Crear una lista de reproducción 
            ListaReproduccion listaGeneral = new ListaReproduccion("Mis Canciones");
            listaGeneral.AgregarCancion("Imagine");
            listaGeneral.AgregarCancion("Bohemian Rhapsody");

            // Crear una lista de reproducción de favoritos
            ListaFavoritos listaFavoritos = new ListaFavoritos("Favoritos del Rock");
            listaFavoritos.AgregarCancion("Stairway to Heaven");

            /*/ Reproducir listas usando la interface
            Console.WriteLine("\nReproduciendo listas:");
            IReproducible reproducibleGeneral = listaGeneral;
            reproducibleGeneral.Reproducir();

            Console.WriteLine();

            IReproducible reproducibleFavoritos = listaFavoritos;
            reproducibleFavoritos.Reproducir();*/
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}