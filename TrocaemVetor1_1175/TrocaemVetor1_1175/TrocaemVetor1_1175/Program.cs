using System;

class URI {

    static void Main(string[] args) {
        int aux;
        int[] numeros = new int[20];

        for (int i = 0; i < 19; i++) {
            int n = int.Parse(Console.ReadLine());
            numeros[i]= n;
        }
        for (int i = 0; i < 10; i++) {
            aux = numeros[i];
            numeros[i] = numeros[19 - i];
            numeros[19 - i] = aux;
        }
        for (int i = 0; i < 19; i++) {
            Console.WriteLine("N["+i+"] = " + numeros[i]);
        }

    }

}