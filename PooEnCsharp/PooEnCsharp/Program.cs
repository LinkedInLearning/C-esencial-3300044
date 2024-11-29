using PooEnCsharp;

internal class Program
{
    private static void Main(string[] args)
    {
        /* POO:
         * Herencia,
         * Polimorfismo,
         * Abstracción,
         * Encapsulamiento
         */


        // Crear una instancia de Cancion
        Cancion cancion = new Cancion("Imagine", "John Lennon", 183);

        // Mostrar información de la canción
        cancion.MostrarInformacion();
    }
}