using System;

class Program 
{
    static void Main() 
    {
        string saludo = "Hola, Mundo!";
        Console.WriteLine(saludo);
        Console.WriteLine("Escribe tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Tu nombre es {nombre}");
    }
}

