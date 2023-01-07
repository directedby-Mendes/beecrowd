using System;

class URI {

    static void Main(string[] args) {

        string[] inteiros = Console.ReadLine().Split();
        int a = int.Parse(inteiros[0]);
        int b = int.Parse(inteiros[1]);

        if(a % b == 0 || b % a ==0) {
            Console.WriteLine("São Múltiplos");
        }
        else Console.WriteLine("Não são Múltiplos");
    }

}