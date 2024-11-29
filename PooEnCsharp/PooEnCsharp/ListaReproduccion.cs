using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEnCsharp
{
    public class ListaReproduccion : IReproducible
    {
        #region Propiedades
        public string Nombre { get; private set; }
        protected List<string> Canciones { get; private set; }
        #endregion

        #region Constructores
        // Constructor de la clase base
        public ListaReproduccion(string nombre)
        {
            Nombre = nombre;
            Canciones = new List<string>();
        }
        #endregion

        #region Métodos
        public void AgregarCancion(string cancion)
        {
            Canciones.Add(cancion);
            Console.WriteLine($"Canción '{cancion}' agregada a la lista '{Nombre}'.");
        }
        
        protected void MostrarCanciones()
        {
            Console.WriteLine($"Lista de reproducción: {Nombre}");
            foreach (var cancion in Canciones)
            {
                Console.WriteLine($"- {cancion}");
            }
        }

        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo lista de Reproducción");
            foreach(var canc in Canciones) { Console.WriteLine($" {canc} "); };
        }
        #endregion
    }
}
