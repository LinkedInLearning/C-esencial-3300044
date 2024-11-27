using System;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Tipos numéricos
        /*
        Console.WriteLine("Tipos numéricos:");

        int miInt = -100;
        byte miByte = 255;
        long miLong = 255;
        decimal miDecimal = 500.50M;
        float miFloat = 1f;

        //Conversión cadenas a tipo numérico
        Console.WriteLine("Ingrese un número entero");
        string entrada = Console.ReadLine();
        int num1 = int.Parse(entrada);
        Console.WriteLine("Ingrese otro número entero");
        string entrada2 = Console.ReadLine();
        int num2 = int.Parse(entrada2);

        //Operaciones y redondeo
        int suma = num1 + num2;
        Console.WriteLine($"Suma = {suma} ");

        double division = suma / 3.0;
        double redondeo = Math.Round(division, 2);

        //Conversión entre tipos numéricos
        byte sumaByte = (byte)suma;
        byte sumaByte = (byte)suma; */
        #endregion

        #region Tipo cadena y caracter
        /* Tipo caracter
         
       char letra = 'l';
       char letra2 = '\x006C';
       char letra3 = (char)108;
       Console.WriteLine($"letra = {letra}");
       Console.WriteLine($"letra2 = {letra2}");
       Console.WriteLine($"letra3 = {letra3}");

       char letraMayuscula = char.ToUpper(letra);
       Console.WriteLine($"letraMayuscula = {letraMayuscula}");

       Console.WriteLine($"¿Es letra? {char.IsLetter(letra)}");
       Console.WriteLine($"¿Es número? {char.IsNumber(letra)}");*/

        /* Tipo cadena

        string holamundo = "Hola mundo";
        Console.WriteLine($"Longitud de hola: {holamundo.Length}");

        string soloHola = holamundo.Substring(0, 4);
        Console.WriteLine(soloHola);

        Console.WriteLine($"holamundo contiene la palabra mundo: {holamundo.Contains("mundo")}"); */

        #endregion

        #region Tipo boleano
        int edad = 15;
        bool esMayor = edad >= 18;

        if(esMayor)
        {
            Console.WriteLine("Es mayor de edad");
        }else
        {
            Console.WriteLine("No es mayor de edad");
        }
        Console.WriteLine($"valor de esMayor {esMayor}");

        #endregion

        #region Arreglos
        
        int[] numeros = new int[5]; // Declaración
        numeros[0] = 10; // Asignación
        // 10, , , ,


        // Inicialización directa
        int[] miArreglo = [1,2,3,4,5];
        int ultimoValor = miArreglo[4];

        
        // Recorrido
        foreach( int i in miArreglo)
        {
            Console.WriteLine($"{i}");
        }

        // Arreglos multidimensionales
        int[,] matrizB =
        {
            {1,2 },
            {3,4},
            {5,6 }
        };
        matrizB[0,1] = 10; //Modificar el valor de una posición en matriz bidimensional 


        //Operaciones con arreglos
        int[] arregloDesordenado = [5, 9, 100, 4, 5, 25];

        int tamañoArreglo = arregloDesordenado.Length;
        int dimensiones = matrizB.Rank;

        Console.WriteLine($" tamañoArreglo arregloDesordenado {tamañoArreglo}");
        Console.WriteLine($" dimensiones de matrizB {dimensiones}");

        Array.Sort(arregloDesordenado);
        Console.WriteLine($" arregloDesordenado ordenado");
        Console.WriteLine(string.Join(", ", arregloDesordenado));

        Array.Reverse(arregloDesordenado);
        Console.WriteLine($" arregloDesordenado ordenado invertido (reverse)");
        Console.WriteLine(string.Join(", ", arregloDesordenado));

        int index = Array.IndexOf(arregloDesordenado, 100);
        Console.WriteLine($" index of 100 en arregloDesordenado {index}");
        #endregion

        #region Tipos nulables
        #endregion
    }
}