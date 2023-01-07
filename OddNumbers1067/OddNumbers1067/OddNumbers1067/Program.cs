using System;

class URI {

    static void Main(string[] args) {
        int cont= 1;
        int x = int.Parse(Console.ReadLine());
        while (cont <= x) {
            Console.WriteLine($"{cont}");
            cont+=2; 
        }
    }
}