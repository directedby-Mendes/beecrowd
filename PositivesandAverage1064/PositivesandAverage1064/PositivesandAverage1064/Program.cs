using System;

class URI {

    static void Main(string[] args) {

        double numeros;
        double media = 0;
        double total = 0;
        int x = 0;
        for (int i = 0; i < 6; i++) {
            numeros = double.Parse(Console.ReadLine());
            if (numeros > 0.0) {
                x += 1;
                media += numeros;
            }
        }
        total = media / x;
        Console.WriteLine($"{x} valores positivos");
        Console.WriteLine ($"{total:F1}");
    }
}