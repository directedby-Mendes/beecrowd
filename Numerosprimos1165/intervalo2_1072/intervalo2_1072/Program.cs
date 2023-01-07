using System;
using System.Collections.Generic;

namespace Exercicio1072 {
    class Program {
        static void Main(string[] args) {
        //    List<int> a = new List<int>();
            int n = int.Parse(Console.ReadLine());
            int x;
            int dentro = 0;
            int fora = 0;

            for (int u = 0; u < n; u++) {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                dentro++;

                else fora++;
        }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }

    }
}