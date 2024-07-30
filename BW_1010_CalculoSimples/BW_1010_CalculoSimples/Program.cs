internal class Program
{
    private static void Main(string[] args)
    {
        int CodeP1, CodeP2, NumP1, NumP2;
        double ValP1, ValP2, ValToPay;

        Console.Write("Digite respecitvamente Codigo/Quatidade/Valor : ");
        string[] P2 = Console.ReadLine().Split(' ');
        CodeP2 = int.Parse(P2[0]);
        NumP2 = int.Parse(P2[1]);
        ValP2 = double.Parse(P2[2]);

        Console.Write("Digite respecitvamente Codigo/Quatidade/Valor : ");
        string[] P1 = Console.ReadLine().Split(' ');
        CodeP1 = int.Parse(P1[0]);
        NumP1 = int.Parse(P1[1]);
        ValP1 = double.Parse(P1[2]);
        

        ValToPay = (NumP1 * ValP1) + (NumP2 * ValP2);

        Console.WriteLine("VALOR A PAGAR: R$ " + ValToPay.ToString("F2"));

    }
}