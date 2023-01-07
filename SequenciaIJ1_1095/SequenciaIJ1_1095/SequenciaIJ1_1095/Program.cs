using System;
class URI {

    static void Main(string[] args) {
        int j = 60;
        for (int i = 1; i<40; i+=3) {
            Console.WriteLine($"I={i} J={j}");
            j -=5;          
        }
    }
}