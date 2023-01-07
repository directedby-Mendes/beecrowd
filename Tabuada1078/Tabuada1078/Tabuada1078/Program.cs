using System;

class URI {

    static void Main(string[] args) {
        int r;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < 11; i++) {
            r = i * n;
            Console.WriteLine(i + " x "+ n + " = " + r);   

        }
    }
}