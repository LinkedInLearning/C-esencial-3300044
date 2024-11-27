using System;

internal class Program
{
    enum Turno
    {
        Ninguno,
        Matutino,
        Vespertino,
        Nocturno
    }

    enum Estado : byte { Activo = 1, Inactivo = 0 };
    private static void Main(string[] args)
    {
        #region Tipo enum

        Console.WriteLine($"{(Turno)3}");
        #endregion

    }
}