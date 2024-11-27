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
        char letra = 'l';
        char letra2 = '\x006C';
        char letra3 = (char)108;
        Console.WriteLine($"letra = {letra}");
        Console.WriteLine($"letra2 = {letra2}");
        Console.WriteLine($"letra3 = {letra3}");

        char letraMayuscula = char.ToUpper(letra);
        Console.WriteLine($"letraMayuscula = {letraMayuscula}");

        Console.WriteLine($"¿Es letra? {char.IsLetter(letra)}");
        Console.WriteLine($"¿Es número? {char.IsNumber(letra)}");
        #endregion

        #region Tipo boleano

        #endregion
    }
}