using System;

class URI {

    static void Main(string[] args) {

        double numeros;
        int x = 0;
        for (int i = 0; i < 6; i++) {
            numeros = double.Parse(Console.ReadLine());
            if (numeros > 0.0) {
                x += 1;
            }
        }
        Console.WriteLine($"{x} Valores positivos");
    }
}