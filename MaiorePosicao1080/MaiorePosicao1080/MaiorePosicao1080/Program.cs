using System;
class URI {

    static void Main(string[] args) {
        int maior = 0;
        int posicao_maior = 1;
        int[] valores = new int[100];
        for (int i = 0; i < valores.Length; i++) {
            valores[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < valores.Length; i++) {
            if (valores[i] > maior) {
                maior = valores[i];
                posicao_maior = i+1;
            }
        }
        Console.WriteLine(maior);
        Console.WriteLine(posicao_maior);
    }

}