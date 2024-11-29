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
        
        public int Duracion { get; set; } 
        #endregion

        #region Constructores
        public Cancion()
        {
            Titulo = "Sin titulo";
            Artista = "Desconocido";
            Duracion = 0;
        }
        
        public Cancion(string titulo, string artista, int duracion)
        {
            Titulo = titulo;
            Artista = artista;
            Duracion = duracion;
        }

        public void Deconstruct(out string titulo, out string artista, out int duracion)
        {
            titulo = Titulo;
            artista = Artista;
            duracion = Duracion;
        }
        #endregion

        #region Métodos

        // Método público
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}, Artista: {Artista}, Duración: {Duracion} segundos");
        }

        // Método protegido
        protected string ConvertirDuracionAMinutos()
        {
            int minutos = Duracion / 60;
            int segundos = Duracion % 60;
            return $"{minutos} minutos y {segundos} segundos";
        }

        // Método interno
        internal void ActualizarDuracion(int nuevaDuracion)
        {
            if (nuevaDuracion > 0)
            {
                Duracion = nuevaDuracion;
                Console.WriteLine($"Duración actualizada a {Duracion} segundos.");
            }
            else
            {
                Console.WriteLine("La duración debe ser mayor a 0.");
            }
        }
        #endregion
    }
}
