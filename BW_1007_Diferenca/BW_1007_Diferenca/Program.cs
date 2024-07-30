internal class Program
{
    private static void Main(string[] args)
    {
        int A, B, C, D, DIF;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());
        DIF = (A * B) - (D * C);

        Console.WriteLine("DIFERENCA = " + DIF);
    }
}