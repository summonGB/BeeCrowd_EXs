using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double TempV, VelV, DistV, Consu;

        TempV = int.Parse(Console.ReadLine());
        VelV = int.Parse(Console.ReadLine());

        DistV =  VelV * TempV;

        //Console.WriteLine(DistV);
        Consu = DistV / 12;

        Console.WriteLine(Consu.ToString("F5"));
    }
}