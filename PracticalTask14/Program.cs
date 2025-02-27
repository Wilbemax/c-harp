using System;


partial class Program
    {
        static void Main(string[] args)
        {
        // Console.Write("Введите строку: ");
        // var inputText = Console.ReadLine();
        // Console.WriteLine("Перевернутая строка: " + Reverse(inputText));

        // Console.WriteLine("Press any key to continue . . .");
        // Console.ReadKey(true);

        Console.WriteLine("1 - первое задание");
        Console.WriteLine("2 - второе задание");
        Console.WriteLine("3 - третье задание");
        Console.WriteLine("4 - четвертое задание");
        Console.WriteLine("5 - пятое задание");

        Console.WriteLine("Выберети задание, введя цифру");
        int x = int.Parse(Console.ReadLine());
        B(x);
    }
}
