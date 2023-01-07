using System;

class URI {

    static void Main(string[] args) {

        string[] lados = Console.ReadLine().Split();
        double a = double.Parse(lados[0]),
               b = double.Parse(lados[1]),
               c = double.Parse(lados[2]);
               double area = ((a + b) * c) / 2;
        if (a < b+c && b < c+a && c < a+b) {
            double p = a + b + c;
            Console.WriteLine($"Perimetro = {p:F1}");
        }
        else Console.WriteLine($"Area = {area:F1}");
        
    } 

}