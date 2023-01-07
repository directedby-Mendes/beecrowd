using System;

class URI
{

    static void Main(string[] args)
    {
        string[] soma = Console.ReadLine(). Split();
        int x = int.Parse(soma[0]);
        double y = double.Parse(soma[1]);
        double valor=0;

        if (y == 1)
        {
            valor = y * 4;
        }
        else if (x == 2)
        {
            valor = y * 4.50;
        }
        else if (x == 3)
        {
            valor = y * 5;
        }
        else if (x == 4)
        {
            valor = y * 2;
        }
        else if (x == 5)
        {
            valor = y * 1.50;
        }
        if ( valor > 0)
        {
            Console.WriteLine($"Total: R$ {valor:F2}");
        }
    }

}