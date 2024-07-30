internal class Program
{
    private static void Main(string[] args)
    {
        int Distancia;
        double Gasto, Consumo;

        Console.Write("Digite a quilomentragem rodada : Km ");
        Distancia = int.Parse(Console.ReadLine());

        Console.Write("Digite o quantos litros voce abasteceu :  ");
        Gasto = double.Parse(Console.ReadLine());

        Consumo = Distancia / Gasto;

        Console.WriteLine(Consumo.ToString("F3") + " km/l");

    }
}