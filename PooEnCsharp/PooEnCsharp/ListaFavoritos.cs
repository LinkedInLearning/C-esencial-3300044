using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PooEnCsharp
{
    public class ListaFavoritos : ListaReproduccion
    {
        private List<string> Favoritos { get; set; }


        #region Constructores
        public ListaFavoritos(string nombre) : base(nombre)
        {
            Favoritos = new List<string>();
        }
        #endregion

        #region Métodos
        // Método público para marcar una canción como favorita
        public void MarcarComoFavorita(string cancion)
        {
            if (Canciones.Contains(cancion))
            {
                Favoritos.Add(cancion);
                Console.WriteLine($"Canción '{cancion}' marcada como favorita.");
            }
            else
            {
                Console.WriteLine($"La canción '{cancion}' no está en la lista '{Nombre}'.");
            }
        }

        // Método público para mostrar las canciones favoritas
        public void MostrarFavoritas()
        {
            Console.WriteLine($"Canciones favoritas en la lista '{Nombre}':");
            foreach (var cancion in Favoritos)
            {
                Console.WriteLine($"{cancion}");
            }
        }

        // Sobrescribir un método para mostrar todas las canciones
        public void MostrarTodo()
        {
            // Llama al método protegido de la clase base
            MostrarCanciones();
            MostrarFavoritas();
        }
        #endregion

    }
}
