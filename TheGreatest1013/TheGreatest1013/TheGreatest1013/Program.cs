using System;
using System.Data;
using System.Text.RegularExpressions;

class URI
{

    static void Main(string[] args)
    {
        string[] Valores = (Console.ReadLine()).Split(' ');
        int a = int.Parse(Valores[0]);
        int b = int.Parse(Valores[1]);
        int c = int.Parse(Valores[2]);
        Console.WriteLine(Math.Max(a, Math.Max(b, c)) + " eh o maior");
        
        }
    }




























