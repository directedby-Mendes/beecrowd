using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int hora = int.Parse(Console.ReadLine());
        int kmhora = int.Parse(Console.ReadLine());
        Console.WriteLine($"{(double)hora*kmhora/12:F3}");
    }
}