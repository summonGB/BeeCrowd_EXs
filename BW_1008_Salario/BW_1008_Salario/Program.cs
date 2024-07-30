internal class Program
{
    private static void Main(string[] args)
    {
        int IDFuncionario, HRTrabalhada;
        double VLHora, Salario;

        Console.WriteLine("Digite seu ID de funcionario:");
        IDFuncionario = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quatidade de horas trabalhadas este mes : ");
        HRTrabalhada = int.Parse(Console.ReadLine());

        Console.Write("Digite seu valor hora U$ ");
        VLHora = double.Parse(Console.ReadLine());

        Salario = VLHora * HRTrabalhada;

        Console.WriteLine("NUMBER = " + IDFuncionario);
        Console.WriteLine("SALARY = U$ " + Salario.ToString("F2"));

    }
}