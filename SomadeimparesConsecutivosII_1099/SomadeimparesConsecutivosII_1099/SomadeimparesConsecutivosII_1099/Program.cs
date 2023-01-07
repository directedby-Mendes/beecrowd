using System;
class URI {
    static void Main(string[] args) {
        int a, b, aux;
        int soma = 0;
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            soma = 0;
            if (a > b) {
                aux = a;
                a = b;
                b = aux;
            }
            for (int j = a + 1; j < b; j++) {
                if (j % 2 != 0) {
                    soma += j;
                }
            }
            Console.WriteLine(soma);
            soma = 0;
        }
    }
}