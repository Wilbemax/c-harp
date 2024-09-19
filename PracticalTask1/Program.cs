// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Text;

namespace PracticalTask1
{
    class Print
    {
        static void Main()
        {

            //////////////////////////////////////////////////////////////////////////////                1
            // int a;
            // int b;
            // Console.Write("a = ");
            // a = int.Parse(Console.ReadLine());

            // Console.Write("b = ");
            // b = int.Parse(Console.ReadLine());

            // int res = a + b;

            // Console.WriteLine("{0} + {1} = {2}", a, b, res);


            /////////////////////////////////////////////////////////////////////////////////              2
            // int a;
            // int b;
            // Console.Write("a = ");
            // a = int.Parse(Console.ReadLine());

            // Console.Write("b = ");
            // b = int.Parse(Console.ReadLine());

            // Console.WriteLine("{0} + {1} = {1} + {0}", a, b);


            /////////////////////////////////////////////////////////////////////////////////////               3
            // int a;
            // int b;
            // int c;

            // Console.Write("a = ");
            // a = int.Parse(Console.ReadLine());

            // Console.Write("b = ");
            // b = int.Parse(Console.ReadLine());

            // Console.Write("c = ");
            // c = int.Parse(Console.ReadLine());


            // int res = a + b + c;

            // Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, res);


            //////////////////////////////////////////////////////////////////////////////////                    4
            // double a;
            // double b;

            // Console.Write("a = ");
            // a = double.Parse(Console.ReadLine());

            // Console.Write("b = ");
            // b = double.Parse(Console.ReadLine());

            // double res = a * b;

            // Console.WriteLine("{0: #.#} * {1: #.#} = {2: #.#}", a, b, res);





            ////////////////////////////////////////////////////////////////////                       5
            // double a;
            // double b;

            // Console.Write("a = ");
            // a = double.Parse(Console.ReadLine());

            // Console.Write("b = ");
            // b = double.Parse(Console.ReadLine());

            // double res = a / b;
            // Console.WriteLine("{0:f3} / {1:#.###} = {2:f3}", a, b, res);

            ////////////////////////////////////////////////////////////////////                       6
            // double a;
            // double b;
            // double c;


            // Console.Write("a = ");
            // a = double.Parse(Console.ReadLine());

            // Console.Write("b = ");
            // b = double.Parse(Console.ReadLine());


            // Console.Write("c = ");
            // c = double.Parse(Console.ReadLine());


            // Console.WriteLine("({0:f2} * {1:f2}) + {2:f2} - {0:f2} + {1:f2}", a, b, c);

            ////////////////////////////////////////////////////////////////////                       7

            Console.OutputEncoding = Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");

            // double a;
            // double b;
            // double c;


            // Console.Write("Наминал купюры = ");
            // a = double.Parse(Console.ReadLine());

            // Console.Write("количество купюр = ");
            // b = double.Parse(Console.ReadLine());


            // double res = a * b;
            // Console.WriteLine("Сумма денег = {0:c2}", res);



            ////////////////////////////////////////////////////////////////////                       8
            // Console.OutputEncoding = Encoding.Unicode;
            // Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");

            // double a;
            // double b;
            // double c;


            // Console.Write("Введите сумму вклада = ");
            // a = double.Parse(Console.ReadLine());

            // Console.Write("Введите процент по вкладу = ");
            // b = double.Parse(Console.ReadLine()) / 100;


            // double res = a * b;
            // Console.WriteLine("Через год начислиться = {0:c2}", res);







            ////////////////////////////////////////////////////////////////////                       9


            // Console.OutputEncoding = Encoding.Unicode;
            // Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");

            // double a;
            // double b;
            // double c;


            // Console.Write("Введите сумму вклада = ");
            // a = double.Parse(Console.ReadLine());

            // Console.Write("Введите процент по вкладу = ");
            // b = double.Parse(Console.ReadLine()) / 100;


            // double res = a * (1 + b*1);
            // Console.WriteLine("В конце года начислиться = {0:c2}", res);


            ////////////////////////////////////////////////////////////////////                       10
            // string name;
            // int age;
            // int year;

            // Console.Write("Как тебя зовут? ");
            // name = Console.ReadLine();

            // Console.Write("Сколько тебе лет? ");
            // age = int.Parse(Console.ReadLine());

            // year = 2009 - age;
            // Console.WriteLine("{0}, ты родился в {1}", name, year);
        }
    }
}

