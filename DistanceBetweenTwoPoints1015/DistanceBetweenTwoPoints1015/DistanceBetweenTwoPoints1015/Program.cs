﻿using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] p1 = (Console.ReadLine().Split(' '));
        double x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
        double y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);

        string[] p2 = (Console.ReadLine().Split(' '));
        double x2 = double.Parse(p2[0], CultureInfo.InvariantCulture);
        double y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);

        double distancia = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
        distancia = Convert.ToSingle(Math.Sqrt(distancia));

        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        Console.ReadKey();
    }
}