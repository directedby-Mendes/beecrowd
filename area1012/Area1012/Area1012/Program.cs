/*Faça um programa que leia três valores de ponto flutuante: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo de base A e altura C.
b) a área do círculo de raio C. (pi = 3,14159)
c) a área do trapézio que tem A e B por base e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.

Entrada
O arquivo de entrada contém três valores duplos com um dígito após o ponto decimal.

Resultado
O arquivo de saída deve conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com uma mensagem correspondente (em português) e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após a vírgula

*/
using System;
using System.Text.RegularExpressions;
using System.Globalization;

class URI
{

    static void Main(string[] args){
        string[] Calculo = Console.ReadLine().Split(' ');

        double a = double.Parse(Calculo[0], CultureInfo.InvariantCulture);
        double b = double.Parse(Calculo[1], CultureInfo.InvariantCulture);
        double c = double.Parse(Calculo[2], CultureInfo.InvariantCulture);

        Console.WriteLine($"TRIANGULO: {(a*c/2).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {(3.14159*c*c).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {((a+b)*c/2).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {(b*b).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {(a*b).ToString("F3", CultureInfo.InvariantCulture)}");
    }

}