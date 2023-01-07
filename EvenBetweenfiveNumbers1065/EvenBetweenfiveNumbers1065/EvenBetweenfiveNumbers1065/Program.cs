using System;

class URI {

    static void Main(string[] args) {

        double numeros;
        int x = 0;
        for (int i = 0; i < 5; i++) {
            numeros = double.Parse(Console.ReadLine());
            if (numeros % 2 ==0) {
                x += 1;         
            }
        }
        Console.WriteLine($"{x} valores pares");
    }
}