using System;
class URI
{
    static void Main(string[] args)
    {

        string[] soma = Console.ReadLine().Split(' ');
        int a = int.Parse(soma[0]);
        int b = int.Parse(soma[1]);
        int c = int.Parse(soma[2]);
        int d = int.Parse(soma[3]);

        if ((b > c && d > a) && (c + d > a + b) && (c >= 0 && d >= 0) && (a % 2 == 0))
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }

}