using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEnCsharp
{
    public class Cancion
    {
        #region Propiedades
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public int Duracion { get; set; } // Duración en segundos
        #endregion

        #region Constructores
        public Cancion(string titulo, string artista, int duracion)
        {
            Titulo = titulo;
            Artista = artista;
            Duracion = duracion;
        }
        #endregion

        #region Métodos
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}, Artista: {Artista}, Duración: {Duracion} segundos");
        }
        #endregion
    }
}
