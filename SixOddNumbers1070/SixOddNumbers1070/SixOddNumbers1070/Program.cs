using System;

class URI {

    static void Main(string[] args) {
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < 12; i++) {
            if (x % 2 != 0) {
                Console.WriteLine(x);
                x++;
            }
            else
                x ++;
        }
    }
}
