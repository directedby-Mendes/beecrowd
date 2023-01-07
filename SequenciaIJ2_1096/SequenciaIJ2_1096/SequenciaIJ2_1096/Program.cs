using System;
class URI {

    static void Main(string[] args) {
        int i = 1;
        for (int j = 7; i<10; j --) {
            Console.WriteLine($"I={i} J={j}");
            if (j == 5) {
                j = 8;
                i += 2;
            }

        }
    }
}