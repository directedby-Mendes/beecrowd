using System;
class URI {
    static void Main(string[] args) {
        int a, b, aux;      
        while (true) {
            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            if (a <= 0 || b <= 0) {
                break;
            }
            if (a > b) {
                aux = a;
                a = b;
                b = aux;
            }
            int soma = 0;
            for (int j = a; j <= b; j++) {
                Console.Write("{0} ", j);
                soma += j;                
            }
            Console.Write("Sum=" + soma);
            Console.WriteLine();
        }       
    }  
}




/*using System;

namespace Exercicio1101 { class MainClass { public static void Main(string[] args) {

        while (true)
        {
            int maior = 0, menor = 0;
            string[] val = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(val[0]);
            int n = Convert.ToInt32(val[1]);

            if (m == 0 || n == 0)
            {
                break;
            }
            if (m >= n)
            {
                maior = m;
                menor = n;
            } else if (m <= n)
            {
                maior = n;
                menor = m;
            }
            int soma = 0;
            for (int c = menor; c<=maior; c++)
            {
                Console.Write("{0} ",c);
                soma += c;
            }
            Console.Write("Sum=" + soma);
            Console.WriteLine();

        }
    }
}
}
*/