using System;

class URI {

    static void Main(string[] args) {
        int n = 0, a = 0, g = 0, d = 0;      
        while (n != 4) {
            n = int.Parse(Console.ReadLine());

            if (n == 1) {
                a++;
            }
            else if (n == 2) {
                g++;
            }
            else if (n == 3) {
                d++;
            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + a);
        Console.WriteLine("Gasolina: " + g);
        Console.WriteLine("Diesel: " + d);
    }
}
