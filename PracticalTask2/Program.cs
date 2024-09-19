using System;

class Hallo
{
    static void Main()
    {
        //Задание 1   Площадь прямоугольного треугольника по двум катетам

        // int a;
        // int b;

        // double res;

        // Console.Write("Введите первый катет:");
        // a = int.Parse(Console.ReadLine());



        // Console.Write("Введите второй катет:");
        // b = int.Parse(Console.ReadLine());

        // res = 0.5 * a * b;
        // Console.WriteLine("Площадь: {0}", res);




        //Задание 2  Наименьшую цифру в натуральном двухзначном числе

        int number;
        Console.Write("Введите двузначное натуральное число: ");
        number = int.Parse(Console.ReadLine());

            
        if (number < 10 || number > 99)
        {
            Console.WriteLine("Число должно быть двузначным.");
            return;
        }

        
        int firstDigit = number / 10;
        int secondDigit = number % 10;

        
        int smallestDigit = Math.Min(firstDigit, secondDigit);

        Console.WriteLine("Наименьшая цифра в числе {0} равна {1}", number, smallestDigit);

    }
}