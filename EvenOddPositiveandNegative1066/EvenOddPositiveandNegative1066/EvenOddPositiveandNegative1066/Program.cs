using System;
class URI {

    static void Main(string[] args) {

        int numeros;
        int pares = 0;
        int impar = 0;
        int positivo = 0;
        int negativo = 0;

        for (int i = 0; i < 5; i++) {
            numeros = int.Parse(Console.ReadLine());
            if (numeros % 2 == 0) {
                pares += 1;
                if (numeros > 0) {
                    positivo += 1;
                }
                if (numeros < 0) {
                    negativo += 1;
                }
            }
            else if (numeros % 2 != 0) {
                impar += 1;
                if (numeros < 0) {
                    negativo += 1;
                }
                if (numeros > 0) {
                    positivo += 1;
                }
            }
        }
        Console.WriteLine($"{pares} valor(es) par(es)");
        Console.WriteLine($"{impar} valor(es) impar(es)");
        Console.WriteLine($"{positivo} valor(es) positivo(s)");
        Console.WriteLine($"{negativo} valor(es) negativo(s)");
    }

}

