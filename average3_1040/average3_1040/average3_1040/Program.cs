/*using System;
using System.Collections;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        string[] notas = Console.ReadLine().Split();

        double n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
        double n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
        double n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
        double n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);
        double media, exame, notaf;

        media = Math.Round(n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / (2 + 3 + 4 + 1);
        Console.WriteLine($"Media: {media}.ToString("F1",CultureInfo.InvariantCulture)");

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        if (media >= 5.0 && media <= 6.9)
        {

            exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Aluno em exame.");
            Console.WriteLine("Nota do exame:" + exame.ToString("f1", CultureInfo.InvariantCulture));
            notaf = (exame + media) / 2;
            if (notaf >= 5.0)
            {
                Console.WriteLine("Aluno aprovado");               
            }
            else
                Console.WriteLine("Aluno reprovado");
        }
        Console.WriteLine($"Média final: {notaf}.ToString("f1", CultureInfo.InvariantCulture)");
    }
}*/

using System.Globalization;

string[] valor = valores.Split();

double valor1 = double.Parse(valor[0], CultureInfo.InvariantCulture);
double valor2 = double.Parse(valor[1], CultureInfo.InvariantCulture);
double valor3 = double.Parse(valor[2], CultureInfo.InvariantCulture);
double valor4 = double.Parse(valor[3], CultureInfo.InvariantCulture);

double total1 = ((valor1 * 2) + (valor2 * 3) + (valor3 * 4) + (valor4 * 1)) / 10;
double total = Math.Round(total1, 1, MidpointRounding.ToEven);
Console.WriteLine("Media: " + total.ToString("F1", CultureInfo.InvariantCulture));

if (total1 >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
    Console.ReadLine();
}
else if (total >= 5.0 && total1 <= 6.9)
{
    Console.WriteLine("Aluno em exame.");
    double notaExame = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
    double average2 = ((total1 + notaExame) / 2);
    double ave2 = Math.Round(average2, 1, MidpointRounding.ToEven);
    if (average2 >= 5.0)
    {
        Console.WriteLine("Aluno aprovado.");
        Console.WriteLine("Media final: " + ave2.ToString("F1", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Aluno reprovado.");
        Console.WriteLine("Media final: " + ave2.ToString("F1", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }

}
else if (total < 5.0)
{
    Console.WriteLine("Aluno reprovado.");
    Console.ReadLine();
}