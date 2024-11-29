using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEnCsharp
{
    public class Cancion
    {
        #region Campos
        private string titulo;
        #endregion

        #region Propiedades
        public string Titulo { 
            get { return titulo; } 
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    titulo = value;
                }
                else
                {
                    throw new ArgumentException("El titulo no puede ser nulo o vacío");
                }
                
            }
        }
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
