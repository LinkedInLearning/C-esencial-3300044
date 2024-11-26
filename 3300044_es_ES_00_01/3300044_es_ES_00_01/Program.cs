using _3300044_es_ES_00_01;

class Program
{
    static async Task Main()
    {

        var cancion1 = new Cancion("Bohemian Rhapsody", "Queen", new TimeSpan(0, 5, 55));

        var playlist = new ListaReproduccion("Clásicos del Rock");

        #region 1.0 try catch finally
        try
        {
            playlist.AgregarCancion(cancion1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            playlist.MostrarCanciones();
        }
        #endregion

        #region 5.0 async await
        await cancion1.Reproducir();
        #endregion
    }
}
