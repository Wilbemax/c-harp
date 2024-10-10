using System;

class Hallo
{
    static void Main()
    {
        //Задание 1   Площадь прямоугольного треугольника по двум катетам

    //    int a;
    //     int b;

    //     double res;

    //     Console.Write("Введите первый катет:");
    //     a = int.Parse(Console.ReadLine());



    //     Console.Write("Введите второй катет:");
    //     b = int.Parse(Console.ReadLine());

    //     res = 0.5 * a * b;
    //     Console.WriteLine("Площадь: {0}", res); 




        //Задание 2  Наименьшую цифру в натуральном двухзначном числе

        int number;
        int smallestDigit;

        Console.Write("Введите двузначное натуральное число: ");
        number = int.Parse(Console.ReadLine());

        if (number < 10 || number > 99)
        {
            Console.WriteLine("Число должно быть двузначным.");
            return;
        }


        // // int firstDigit = number / 10;
        // // int secondDigit = number % 10;


        // // smallestDigit = Math.Min(firstDigit, secondDigit);



        // // or
 
        smallestDigit = (number % 10 >= number / 10) ? number / 10 : number % 10;


        // // or


        // if (number % 10 >= number / 10) {
        //     smallestDigit = number % 10 ;
        // } else {
        //     smallestDigit = number / 10;
        // }


        Console.WriteLine("Наименьшая цифра в числе {0} равна {1}", number, smallestDigit);


        // Задание 3) Число Х является перевертышем числа Y. Зная значение числа Y, найдите исходное число X.

        // int x;
        // int y;

        // Console.Write("Введите Y:");
        // y = int.Parse(Console.ReadLine());

        // int first;
        // int second;
        // int third;

        // first = y % 10;
        // y /= 10;
        // second = y % 10;
        // y /= 10;
        // third = y % 10;

        // Console.WriteLine("X = {0}{1}{2}", first, second, third);
    }
}