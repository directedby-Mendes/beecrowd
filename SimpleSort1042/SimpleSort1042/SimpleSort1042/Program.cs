using System;

class URI {

    static void Main(string[] args) {

        string[] valores = Console.ReadLine().Split();
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);  
        int c = int.Parse(valores[2]);

        int d = a;
        int e = b;
        int f = c;

        if(d > e && d > f) {
            int aux = d;
            d = f;
            f = aux;
        }
        else if(e > d && e > f) {
            int aux = e;
            e = f;
            f = aux;
        }
        if(d > e) {
            int aux = d;
            d = e;
            e = aux;
        }
        Console.WriteLine($"{d}\n{e}\n{f}\n\n{a}\n{b}\n{c}");
    }

}