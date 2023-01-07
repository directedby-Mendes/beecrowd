using System;
class URI {
    static void Main(string[] args) {
        int a, b, aux;
        while (true) {
            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            if (a == b) {
                break;
            }
            if (a > b) {
                Console.WriteLine("Decrescente");
            }
            else if (b > a) {
                Console.WriteLine("Crescente");
            }
        }
    }
}