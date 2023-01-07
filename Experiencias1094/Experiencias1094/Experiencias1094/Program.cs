using System;
class URI {

    static void Main(string[] args) {
        string tipo;
        int n = 0, quantia=0, rato = 0, sapo = 0, coelho = 0;
        double cont = 0;
        while ((n < 1) || (n > 15)) {
            n = int.Parse(Console.ReadLine());
            break;
        }

        for (int i = 0; i < n; i++) {
            string[] valores = Console.ReadLine().Split();
            quantia = int.Parse(valores[0]);
            tipo = (valores[1]);
            cont += quantia;

            if (tipo == "C") {
                coelho += quantia;
            }
            else if (tipo == "R") {
                rato += quantia;
            }
            else if (tipo == "S") {
                sapo += quantia;
            }
        }
        double perccoelho=0, percrato=0, percsapo=0;
        perccoelho = ((100 * coelho) / cont);
        percrato = ((100 * rato) / cont);
        percsapo = ((100 * sapo) / cont) ;    
        Console.WriteLine($"Total: {cont} cobaias");
        Console.WriteLine($"Total de coelhos: {coelho}");
        Console.WriteLine($"Total de ratos: {rato}");
        Console.WriteLine($"Total de sapos: {sapo}");
        Console.WriteLine($"Percentual de coelhos: {perccoelho:F2} %");
        Console.WriteLine($"Percentual de ratos: {percrato:F2} %");
        Console.WriteLine($"Percentual de sapos: {percsapo:F2} %");

    }
}