using System;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Operadores matemáticos
        /*
        Console.Write("Ingresa un número: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Ingrese otro número: ");
        int y = int.Parse(Console.ReadLine());

        
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
        /*
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
        */

        #endregion

        #region Operadores lógicos
        /*
        // AND &&
        // OR ||
        // NOT !

        #region ejercicio
        Console.Write("Ingrese la duración de la canción (en segundos): ");
        int duracion = int.Parse(Console.ReadLine());

        Console.Write("¿Es la canción favorita del usuario? (true/false): ");
        bool esFavorita = bool.Parse(Console.ReadLine());

        Console.Write("¿Está habilitado el modo aleatorio? (true/false): ");
        bool modoAleatorio = bool.Parse(Console.ReadLine());

        // Evaluar si la canción puede reproducirse
        if ((duracion <= 300 && !modoAleatorio) || esFavorita)
        {
            Console.WriteLine("La canción se reproduce.");
        }
        else
        {
            Console.WriteLine("La canción no se reproduce.");
        }

        // Mensaje adicional
        bool esCancionLarga = duracion > 300;
        Console.WriteLine($"¿La canción es larga (más de 5 minutos)? {esCancionLarga}");
        
        #endregion*/
        #endregion

        #region Sentencias condicionales
        /*Console.Write("Ingrese la duración de la canción (en segundos): ");
        int duracion = int.Parse(Console.ReadLine());
        bool esAdmin = true;

        // Evaluar si la canción puede reproducirse
        if (duracion == 0)
        {
            Console.WriteLine("Duración 0 es inválida");
            if(esAdmin)
            {
                Console.WriteLine("Indica una nueva duración");
                //Read
            }
            else
            {
                //if(esAdmin) Console.WriteLine("Esta es otra condición anidada en el else");

            }
        }
        else if (duracion <= 300)
        {
            Console.WriteLine("La canción dura 5 minutos o menos");
        }
        else
        {
            Console.WriteLine("La canción dura más de 5 minutos");
        }*/
        #endregion

        #region Switch
        /*
        Console.Write("Ingrese la duración de la canción (en segundos): ");
        int duracion = int.Parse(Console.ReadLine());
        bool esAdmin = true;

        switch (duracion)
        {
            case 0:
                Console.WriteLine("Duración 0 es inválida");
                if (esAdmin)
                {
                    Console.WriteLine("Indica una nueva duración");
                    // Leer nueva entrada si es necesario
                }
                break;

            case <= 300:
                Console.WriteLine("La canción dura 5 minutos o menos");
                break;

            default:
                Console.WriteLine("La canción dura más de 5 minutos");
                break;
        }*/
        #endregion

        #region Ciclo for
        /*
        Console.Write("Ingrese un número entero");
        int numero = int.Parse(Console.ReadLine());

        for (int contador = 0; contador <= numero; contador++)
        {
            Console.WriteLine($"{contador}");
        }

        string[] canciones = { "Satisfaction", "Respect", "Stairway to heaven" };
        for (int i = 0; i < canciones.Length; i++)
        {
            Console.WriteLine($"{i} {canciones[i]}");
        }*/
        #endregion

        #region Ciclo while y do-while
        /*
        // While
        string[] canciones = { "Satisfaction", "Respect", "Stairway to heaven" };
        int cantidad = 0;
        while (cantidad > 0)
        {
            Console.WriteLine($"{cantidad}");
            cantidad--; //decremento para iterar y evitar ciclo infinito
        }

        // Do-while 
        Console.WriteLine($"Do-while");
        int cantidad2 = 0;
        do
        {
            Console.WriteLine($"{cantidad2}");
            cantidad2--; //decremento para iterar y evitar ciclo infinito
        } while (cantidad2 > 0);*/
        #endregion

        #region Ciclo foreach
        /*
        string[] canciones = { "Satisfaction", "Respect", "Stairway to heaven" };

        for (int i = 0; i < canciones.Length; i++)
        {
            Console.WriteLine($"{i} {canciones[i]}");
        }

        foreach (var cancion in canciones)
        {
            Console.WriteLine($"{cancion}");
        } */

        #endregion

        #region Excepciones
        try
        {
            Console.Write("Ingrese el numerador: ");
            int numerador = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el denominador: ");
            int denominador = int.Parse(Console.ReadLine());

            int resultado = numerador / denominador;
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            Console.WriteLine($"{ex.Message}");
        }
        catch (FormatException ex) {
            Console.WriteLine("Erro de formato: Ingresa un número entero");
            Console.WriteLine($"{ex.StackTrace}");
        }
       
        #endregion
    }
}