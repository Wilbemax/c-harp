using System;

class Hallo
{
    static void Main()
    {
//---------------------------------------1
        //12
        int x; 
        double res;
        Console.Write("Введите значение функции: ");
        x = int.Parse(Console.ReadLine());

        if ( x > 1) {
           res = Math.Log(Math.Pow(x, 4)- 1) * Math.Log( 1 + x );
           Console.WriteLine(res);
        }else{
            Console.WriteLine("Функция не определена в точке", x);
        }

        //-----------------------------------------------------2
        // int mast;
        // int number;

        // string mastString = null;
        // string numberString = null;

        // Console.Write("Введите масть (от 1 до 4): ");
        // mast = int.Parse(Console.ReadLine());

        // Console.Write("Введите достоинство от 6 до 14: ");
        // number = int.Parse(Console.ReadLine());

        // switch (number)
        // {
        //     case 6:
        //         numberString = "Шестерка";
        //         break;
        //     case 7:
        //         numberString = "Семерка";
        //         break;
        //     case 8:
        //         numberString = "Восьмерка";
        //         break;
        //     case 9:
        //         numberString = "Девятка";
        //         break;
        //     case 10:
        //         numberString = "Десятка";
        //         break;
        //     case 11:
        //         numberString = "Валет";
        //         break;
        //     case 12:
        //         numberString = "Дама";
        //         break;
        //     case 13:
        //         numberString = "Король";
        //         break;
        //     case 14:
        //         numberString = "Туз";
        //         break;
        //     default:
        //         Console.WriteLine("Такого достоинства нет");
        //         break;
        // }

        // switch (mast)
        // {
        //     case 1:
        //         mastString = "Черви";
        //         break;
        //     case 2:
        //         mastString = "Крести";
        //         break;
        //     case 3:
        //         mastString = "Пики";
        //         break;
        //     case 4:
        //         mastString = "Буби";
        //         break;
        //     default:
        //         Console.WriteLine("Такой масти нет");
        //         break;
        // }

        // if (!string.IsNullOrEmpty(mastString) && !string.IsNullOrEmpty(numberString))
        // {
        //     Console.WriteLine($"{numberString} {mastString}");
        // }
    }
}