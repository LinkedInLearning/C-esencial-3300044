using System;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Operadores matemáticos

        Console.Write("Ingresa un número: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Ingrese otro número: ");
        int y = int.Parse(Console.ReadLine());

        /*
        int suma = x + y;
        int resta = x - y;
        int mult = x * y;
        int div = x / y;
        int mod = x % y;

        Console.WriteLine($"suma = {suma}");
        Console.WriteLine($"suma = {resta}");
        Console.WriteLine($"suma = {mult}");
        Console.WriteLine($"suma = {div}");
        Console.WriteLine($"suma = {mod}");

        int resultado = (2 + 5) * 4; //28
        Console.WriteLine($"resultado = {resultado}");

        int divEntero = 5 / 2; //2
        double divDoub = 5 / 2.0; //2.5;
        Console.WriteLine($"divEntero = {divEntero}");
        Console.WriteLine($"divDoub = {divDoub}");

        Console.WriteLine($"módulo = {10 % 2 == 0}"); // True
        */

        #endregion

        #region Operadores de asignación
        /*
        //=
        // +=
        x += 5; // x = x + 5;
        y -= 5;
        // *=
        // /=
        // %=

        // &=

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
        */
        #endregion
        #region Operadores de comparación
        if (x == y)
        {
            Console.WriteLine($"x es igual a y");
        }
        if (x != y)
        {
            Console.WriteLine($"x es diferente a y");
        }
        if (x > y)
        {
            Console.WriteLine($"x es mayor que y");
        }
        if (x >= y)
        {
            Console.WriteLine($"x es igual o mayor a y");
        }

        //"Hola" "hola"
        if ("Hola" == "hola") { //false 
        }

        // los operador que usemos en un ciclo for, cambia el número de iteraciones
        for(int i = 0; i <= x; i++)
        {
        }
        Console.WriteLine(x+ y > 10);

        #endregion

    }
}