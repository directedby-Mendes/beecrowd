using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {

        double salario = double.Parse(Console.ReadLine());
        double reajuste;
        double dif;
        if (salario >= 0 && salario <= 400.00) {
            dif = salario * 0.15;
            reajuste = dif + salario;
            Console.WriteLine("Novo salario: " + reajuste.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + dif.ToString("F2"));
            Console.WriteLine("Em percentual: 15%");
        }
        else if (salario >= 400.01 && salario <= 800.00) {
            dif = salario * 0.12;
            reajuste = dif + salario;
            Console.WriteLine("Novo salario: " + reajuste.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + dif.ToString("F2"));
            Console.WriteLine("Em percentual: 12%");
        }
        else if (salario >= 800.01 && salario <= 1200.00) {
            dif = salario * 0.10;
            reajuste = dif + salario;
            Console.WriteLine("Novo salario: " + reajuste.ToString("F2"));
            Console.WriteLine("Reajuste ganho: "  + dif.ToString("F2"));
            Console.WriteLine("Em percentual: 10%");
        }
        else if (salario >= 1200.01 && salario <= 2000.00) {
            dif = salario * 0.07;
            reajuste = dif + salario;
            Console.WriteLine("Novo salario: " + reajuste.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + dif.ToString("F2"));
            Console.WriteLine("Em percentual: 7%");
        }
        else if (salario > 2000.00) {
            dif = salario * 0.04;
            reajuste = dif + salario;
            Console.WriteLine("Novo salario: " + reajuste.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + dif.ToString("F2"));
            Console.WriteLine("Em percentual: 4%");
        }
    }
}