
namespace CaracteristicasC
{
    internal class Cancion
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public TimeSpan Duracion { get; set; }

        public Cancion(string titulo, string artista, TimeSpan duracion)
        {
            Titulo = titulo;
            Artista = artista;
            Duracion = duracion;
        }

        public async Task Reproducir()
        {
            await Task.Delay(2000);
            Console.WriteLine($"Reproduciendo '{Titulo}' de {Artista}... ({Duracion:mm\\:ss})"); //6.0 interpolación
        }
    }
}
