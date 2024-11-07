using System;

class Program
{
    static void Main()
    {
        string str;

        Console.Write("Введите строку: ");
        str = Console.ReadLine();

        string x;
        string y;

        int countX = 0, countY = 0;

        Console.Write("Введите букву №1 для проверки: ");
        x = Console.ReadLine();

        Console.Write("Введите букву №2 для проверки: ");
        y = Console.ReadLine();

        // 1
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == x[0]) countX++;
            if (str[i] == y[0]) countY++;
        }

        Console.WriteLine("\nКол-во вхождений выбранных символов");
        Console.WriteLine("x: {0}, y: {1}", countX, countY);

        // 2
        if (countX > countY)
        {
            Console.WriteLine("Символ №1 '{0}' встречается чаще", x);
        }
        else if (countX < countY)
        {
            Console.WriteLine("Символ №2 '{0}' встречается чаще", y);
        }
        else
        {
            Console.WriteLine("Символы '{0}' и '{1}' равны по количеству вхождения", x, y);
        }

        // 3
        string res = "";

        for (int i = 0; i < str.Length - 1; i += 2)
        {
            if (str[i] == str[i + 1])
            {
                res += str[i].ToString() + str[i + 1].ToString();
            }
        }

        if (res.Length == 0)
        {
            Console.WriteLine("Нет попарных символов");
        }
        else
        {
            Console.WriteLine("Попарные символы: {0}", res);
        }
    }
}