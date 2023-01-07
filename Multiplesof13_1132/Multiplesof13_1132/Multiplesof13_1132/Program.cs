/*using System;

class URI {

    static void Main(string[] args) {

        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int resto = start % 13;

        if(resto != 0) {
            int falta = 13 - resto;
            start += falta;
        }
        for (int i = start; i < end; i+=13) {
            Console.WriteLine(i);

        }
    }
}*/

using System;

class URI {

    static void Main(string[] args) {

        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        if (start > end) {
            int aux = start;
            start = end;
            end = aux;
        }
        int soma = 0;

        for (int i = start; i <= end; i++){
            if (i % 13 != 0)
                    soma += i;
        }
        Console.WriteLine(soma);
    }
}


