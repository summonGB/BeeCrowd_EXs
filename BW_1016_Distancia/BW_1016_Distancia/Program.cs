internal class Program
{
    private static void Main(string[] args)
    {
        int Car1, Car2, Temp, Time;

        Car1 = 60;
        Car2 = 90;

        Temp = int.Parse(Console.ReadLine());

        Time = Temp * 2;

        Console.WriteLine(Time + " minutos");

    }
}