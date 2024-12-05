using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Task1(); // Если хотите запустить Task1, раскомментируйте эту строку
        Task2();
    }

    static void Task1()
    {
        HashSet<char> setA = new HashSet<char>();
        HashSet<char> setB = new HashSet<char>();
        HashSet<char> setC = new HashSet<char>();
        HashSet<char> setD = new HashSet<char>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введите значение для множества A {0}: ", i);
            char value = Console.ReadLine()[0];
            setA.Add(value);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введите значение для множества B {0}: ", i);
            char value = Console.ReadLine()[0];
            setB.Add(value);
        }

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Введите значение для множества C {0}: ", i);
            char value = Console.ReadLine()[0];
            setC.Add(value);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введите значение для множества D {0}: ", i);
            char value = Console.ReadLine()[0];
            setD.Add(value);
        }

        HashSet<char> intersectionAC = new HashSet<char>(setA);
        intersectionAC.IntersectWith(setC);

        HashSet<char> X = new HashSet<char>(intersectionAC);
        X.UnionWith(setB);

        HashSet<char> intersectionAB = new HashSet<char>(setA);
        intersectionAB.IntersectWith(setB);

        HashSet<char> unionCD = new HashSet<char>(setC);
        unionCD.UnionWith(setD);

        HashSet<char> Y = new HashSet<char>(intersectionAB);
        Y.ExceptWith(unionCD);

        // Вывод результатов
        Console.WriteLine("Множество X: " + string.Join(", ", X));
        Console.WriteLine("Множество Y: " + string.Join(", ", Y));
    }

    static void Task2()
    {
        HashSet<int> setA = new HashSet<int>();
        for (int i = 0; i <= 255; i++)
        {
            setA.Add(i);
        }

        int lastNum = -1;
        int count = 0;

        while (setA.Count > 0)
        {
            Console.Clear();
            Console.Write("Введите число (0-255): ");
            if (!int.TryParse(Console.ReadLine(), out int nowNum))
            {
                Console.WriteLine("Ошибка: введите корректное число.");
                continue;
            }

            if (nowNum < 0 || nowNum > 255)
            {
                Console.WriteLine("Ошибка: число должно быть в диапазоне от 0 до 255.");
                continue;
            }

            if (lastNum != -1 && Math.Abs(lastNum - nowNum) < 7)
            {
                Console.WriteLine("Ошибка: разница между числами должна быть больше или равна 7.");
                break;
            }

            if (!setA.Contains(nowNum))
            {
                Console.WriteLine("Ошибка: это число уже было введено.");
                break;
            }

            setA.Remove(nowNum);
            lastNum = nowNum;
            count++;
        }

        Console.WriteLine($"Количество правильно введенных чисел: {count}");
    }
}