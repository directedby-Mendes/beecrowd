using System;

class URI {

    static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());
        int x = 0;

        for (int i = 1; i <= n*4; i++) {
            Console.Write($"{i} ");
            i++;
            Console.Write($"{i} ");
            i++;
            Console.Write($"{i}");
            i++;
            Console.WriteLine(" PUM");
            
        }
      
    }
}

