/*using System;
class URI {

    static void Main(string[] args) {
        int i = 1;
        int j = 7;
        for (; j != 13; ;) {
            Console.WriteLine($"I={i} J={j}");
            if (j == i + 4) {
                j += 10;
                i += 2;
            }
        }
    }
}*/

using System;
class URI {

    static void Main(string[] args) {
        int i = 1;
        int j = 7;
        while (i <= 9) {
            Console.WriteLine($"I={i} J={j}");
            Console.WriteLine($"I={i} J={j -= 1}");
            Console.WriteLine($"I={i} J={j -= 1}");
            i += 2;
            j += 4;
        }
    }
}