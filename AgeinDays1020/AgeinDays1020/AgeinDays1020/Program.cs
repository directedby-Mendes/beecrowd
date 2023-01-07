using System;
class URI
{

    static void Main(string[] args)
    {

        int idade, ano, mes, dias;
        idade = int.Parse(Console.ReadLine());
        ano = idade / 365;
        mes = ((idade % 365) / 30);
        dias = ((idade % 365) % 30);
        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mês(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}