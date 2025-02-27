using System;


partial class Program
{
    static void D()
    {
        Console.Write("Введите искомый x(целое число):");
        double x = Double.Parse(Console.ReadLine());
        double a = 0.5;
        double z = Math.Log(Math.Sqrt(Math.Sin(x) / (5 * x + 4))) - Math.Pow(Math.E, a / x) + Math.Sqrt(Math.Sin(x / (Math.Pow(x, 2) + 1)));
        Console.WriteLine("Ответ: {0}", z);
    }
}
