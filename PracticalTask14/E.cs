using System;


partial class Program
{
    static void E()
    {
        Console.Write("Введите X:");
        double x = Double.Parse(Console.ReadLine());
        Console.Write("Введите до какого члена считать сумму:");
        int n = int.Parse(Console.ReadLine());
        double sum = 0.0;
        for (int i = 1; i < n; i++)
        {
            sum += 1 / Math.Pow(x, i);
        }
        Console.WriteLine("Сумма: {0}", sum);
    }
}
