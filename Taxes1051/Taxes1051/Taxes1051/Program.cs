using System;

class URI {

    static void Main(string[] args) {

        double salary = double.Parse(Console.ReadLine());
        double imposto;

        if (salary >= 0.00 && salary <= 2000.00){
            Console.WriteLine("Isento");
        }
        else if (salary >= 2000.00 && salary <= 3000.00){
            imposto = ((salary - 2000.00) * 0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }
         else if (salary >= 3000.01 && salary <= 4500.00){
            imposto = ((salary-3000.00) * 0.18 + 1000.00 *0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }
         else if (salary > 4500.00){
            imposto = ((salary - 4500.00) * 0.28 + 1500.00*0.18 +1000.00*0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }
    }
}