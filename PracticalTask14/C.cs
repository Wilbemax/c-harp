using System;


partial class Program
{
    static void C()
    {
        Console.Write("Введите искомый x(целое число):");
        double x = Double.Parse(Console.ReadLine());
        double a = Math.Sin(x);
        double z = Math.Sqrt(Math.Abs(Math.Sin(x)/(Math.Pow(x, 2) + 4))) + Math.Sin(Math.Abs(Math.Pow(a, 4)));
        Console.WriteLine("Ответ: {0}", z);
    }
}
