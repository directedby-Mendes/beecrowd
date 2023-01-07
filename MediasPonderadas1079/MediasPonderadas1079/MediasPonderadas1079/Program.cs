using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            string[] valores = Console.ReadLine().Split();
            double a = double.Parse(valores[0], new CultureInfo("en-US"));
            double b = double.Parse(valores[1], new CultureInfo("en-US"));
            double c = double.Parse(valores[2], new CultureInfo("en-US"));

            double resultado = (a * 0.2 + b * 0.3 + c * 0.5);
            Console.WriteLine(resultado.ToString("F1"));
        }
    }
}