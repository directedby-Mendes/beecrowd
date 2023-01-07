/*using System;

class URI
{

    static void Main(string[] args)
    {
        string[] baskara = Console.ReadLine().Split(' ');
        double a = double.Parse(baskara[0]);
        double b = double.Parse(baskara[1]);
        double c = double.Parse(baskara[2]);
        double r1, r2, delta1,delta2;

        delta = ((b * b) - (4*a*c));
      
        if (delta <= 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");
            Console.ReadKey();
        }
        else
        {
            r1 = (((-b) + Math.Sqrt(delta)) / 2 * a);
            r2 = (((-b) - Math.Sqrt(delta)) / 2 * a);
            Console.WriteLine($"R1 = {r1:F5}");
            Console.WriteLine($"R2 = {r2:F5}");
        }
    }

}*/

using System;
using System.Globalization;

class URI
{

    private static void Main(string[] args)
    {
        String[] entradas = Console.ReadLine().Split(' ');

        double a = double.Parse(entradas[0]);
        double b = double.Parse(entradas[1]);
        double c = double.Parse(entradas[2]);

        double delta = Math.Pow(b, 2) - 4 * a * c;
        double raizDelta = Math.Sqrt(delta);

        if (a == 0 || delta < 0.0)
            Console.WriteLine("Impossivel calcular");
        else
        {
            double x1 = (-b + raizDelta) / (2 * a);
            double x2 = (-b - raizDelta) / (2 * a);

            Console.WriteLine($"R1 = {x1.ToString("0.00000", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"R2 = {x2.ToString("0.00000", CultureInfo.InvariantCulture)}");
        }

        Console.ReadLine();
    }
}