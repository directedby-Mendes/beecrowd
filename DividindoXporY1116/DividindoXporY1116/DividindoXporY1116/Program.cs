using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            string[] valores = Console.ReadLine().Split(' ');
            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            }           
            else {
                double divisao = (double)X/Y;
                Console.WriteLine(divisao.ToString("f1", CultureInfo.InvariantCulture));
            }
        }
    }
}


