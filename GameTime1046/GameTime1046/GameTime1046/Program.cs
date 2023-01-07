using System;

class URI {

    static void Main(string[] args) {

        string[] horas = Console.ReadLine().Split();
        int h1 = int.Parse(horas[0]);
        int h2 = int.Parse(horas[1]);
        int z=24;

        if (h1 > h2) {
            z = z - h1 + h2;
            Console.WriteLine("O JOGO DUROU " + z + " HORA(S)");
        }
        else if (h1 < h2) {
            z = h2 - z + z - h1;
            Console.WriteLine("O JOGO DUROU " + z + " HORA(S)");
        }
        else if (h1 == h2) {
            Console.WriteLine("O JOGO DUROU " + z + " HORA(S)");
        }
    }
}