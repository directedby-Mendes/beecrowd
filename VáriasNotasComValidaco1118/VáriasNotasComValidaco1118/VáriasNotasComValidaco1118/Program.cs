using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {
      double m, n, t, calc = 1;
        
        do {
            do {
                m = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (m < 0.0 || m > 10.0) {
                    Console.WriteLine("nota invalida");
                }

            } while (m < 0.0 || m > 10.0);

            do {
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (n < 0.0 || n > 10.0) {
                    Console.WriteLine("nota invalida");
                }

            } while (n < 0.0 || n > 10.0);


            Console.WriteLine("media = {0:0.00}", t = (m + n) / 2);

            do {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                calc = int.Parse(Console.ReadLine());

            } while (calc != 1 && calc != 2);

        } while (calc == 1);

    }
}