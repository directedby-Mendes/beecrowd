using System;

class URI {

    static void Main(string[] args) {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int total = 0;

        if (x < y) {
            for (int i = x + 1; i < y; i++) {
                if (i % 2 != 0) {
                    total += i;
                }
            }
        }
        else {
            for (int i = y + 1; i < x; i++) {
                if (i % 2 != 0) {
                    total += i;
                }
            }
        }
        Console.WriteLine(total);
    }
}