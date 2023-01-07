using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        double media = 0;
        int i = 0;
        double t=0;
        while (i < 2) {
            double n = double.Parse(Console.ReadLine());
            if (n < 0 || n > 10) {
                Console.WriteLine("nota invalida");
            }
            else {
                i++;
                media += n;
            }
            t = media / 2;
          
        }
        Console.WriteLine("media = " + t.ToString("f2", CultureInfo.InvariantCulture));
    }
}