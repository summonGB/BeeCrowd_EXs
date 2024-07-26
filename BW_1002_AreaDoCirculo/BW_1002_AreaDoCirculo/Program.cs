using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        double raio, pi, raio1, area;

        pi = 3.14159;

        raio1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        raio = Math.Pow(raio1, 2.0);

        area = pi * raio;


        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
    }
}