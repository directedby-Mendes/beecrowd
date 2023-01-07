using System;

class URI {

    static void Main(string[] args) {
        int i, j,x=0;
        for (j = 1; j <= 3; j++) {
            Console.WriteLine($"I={x} J={j}");
        }

        for (i = 0.2; i <= 2; i = i + 0.2) {
            for (j = 1; j <= 3; j++) {
                Console.WriteLine($"I={i} J={j+i}");
            }
        }
    }
}