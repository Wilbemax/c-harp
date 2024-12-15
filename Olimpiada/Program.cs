using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Olipiada
{
    class DataType
    {
        static void Main()
        {
            // Простой тип данных: строка
            string hallo = "halllo";
            Console.WriteLine(hallo);  // Вывод строки
            Console.WriteLine(hallo.Length);  // Длина строки
            Console.WriteLine(hallo.ToUpper());  // Преобразование строки в верхний регистр
            Console.WriteLine(hallo.Replace("l", "z"));  // Замена символов

            // Простой тип данных: целое число
            int num1 = 123;
            Console.WriteLine(num1);  // Вывод целого числа
            Console.WriteLine(num1.ToString());  // Преобразование числа в строку
            Console.WriteLine(num1.CompareTo(100));  // Сравнение с другим числом (возвращает 1, если больше, -1, если меньше, 0 если равно)

            // Простой тип данных: длинное число
            long num2 = 9223854775;
            Console.WriteLine(num2);  // Вывод длинного числа
            Console.WriteLine(num2.ToString());  // Преобразование в строку
            Console.WriteLine(num2.CompareTo(1000000000));  // Сравнение с другим длинным числом

            // Простой тип данных: число с плавающей точкой
            double num3 = 23.32;
            Console.WriteLine(num3);  // Вывод числа с плавающей точкой
            Console.WriteLine(num3.ToString("F2"));  // Форматированный вывод (2 знака после запятой)
            Console.WriteLine(num3.Equals(23.32));  // Сравнение с другим значением

            // Массивы (не динамические)
            int[] nums = { 1, 2, 3 };
            Console.WriteLine(nums.Length);  // Длина массива
            Console.WriteLine(nums.GetValue(0));  // Получение элемента массива по индексу
            Array.Reverse(nums);  // Переворачиваем массив
            Console.WriteLine(string.Join(", ", nums));  // Вывод массива как строки

            // Двумерные массивы
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(matrix.GetLength(0));  // Количество строк
            Console.WriteLine(matrix.GetLength(1));  // Количество столбцов

            // Динамические коллекции
            List<int> dynamicList = new List<int>();
            dynamicList.Add(1);  // Добавление элемента
            dynamicList.Add(2);
            Console.WriteLine(dynamicList.Count);  // Количество элементов в списке
            dynamicList.RemoveAt(0);  // Удаление элемента по индексу
            dynamicList.Add(3);
            Console.WriteLine(string.Join(", ", dynamicList));  // Вывод элементов списка

            // Словарь (Dictionary)
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "один");
            dict.Add(2, "два");
            Console.WriteLine(dict.ContainsKey(1));  // Проверка наличия ключа
            Console.WriteLine(dict[1]);  // Получение значения по ключу

            // Очередь (Queue)
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);  // Добавление элемента в очередь
            queue.Enqueue(2);
            Console.WriteLine(queue.Count);  // Количество элементов в очереди
            Console.WriteLine(queue.Peek());  // Получение первого элемента без удаления
            Console.WriteLine(queue.Dequeue());  // Удаление и получение первого элемента

            // Стек (Stack)
            Stack<int> stack = new Stack<int>();
            stack.Push(1);  // Добавление элемента в стек
            stack.Push(2);
            Console.WriteLine(stack.Count);  // Количество элементов в стеке
            Console.WriteLine(stack.Peek());  // Получение верхнего элемента без удаления
            Console.WriteLine(stack.Pop());  // Удаление и получение верхнего элемента

            // Хэш-сет (HashSet) - множество уникальных элементов
            HashSet<int> visited = new HashSet<int>();
            visited.Add(1);  // Добавление элемента
            visited.Add(2);
            visited.Add(2);  // Повторное добавление не происходит
            Console.WriteLine(visited.Count);  // Количество уникальных элементов
            visited.Remove(1);  // Удаление элемента
            Console.WriteLine(visited.Contains(1));  // Проверка наличия элемента

            // Отсортированное множество (SortedSet)
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(3);
            sortedSet.Add(1);
            sortedSet.Add(2);
            Console.WriteLine(sortedSet.Min);  // Минимальный элемент в отсортированном множестве
            Console.WriteLine(sortedSet.Max);  // Максимальный элемент в отсортированном множестве

            // Nullable типы данных
            Nullable<int> nullable = null;
            Console.WriteLine(nullable.HasValue);  // Проверка, имеет ли значение
            Console.WriteLine(nullable.GetValueOrDefault());  // Получение значения или значение по умолчанию (0 для числовых типов)

            Console.ReadKey();
        }

        static void ReadFileFileStream()
        {
            // Чтение и запись файла с использованием FileStream
            FileStream fileIn = new FileStream("D:/c-harp/PracticalTask9/text.txt", FileMode.Open, FileAccess.Read);
            FileStream fileOut = new FileStream("D:/c-harp/PracticalTask9/newText.txt", FileMode.Create, FileAccess.Write);

            int i;
            while ((i = fileIn.ReadByte()) != -1)
            {
                fileOut.WriteByte((byte)i);  // Чтение и запись по одному байту
            }

            fileIn.Close();
            fileOut.Close();
        }

        static void ExempleOfReadinFile()
        {
            // Пример чтения файла и подсчета вхождений символа
            Console.Write("Введите искомый символ: ");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int count = 0;

            using (FileStream fileIn = new FileStream("D:/c-harp/PracticalTask9/text.txt", FileMode.Open, FileAccess.Read))
            {
                int i;
                while ((i = fileIn.ReadByte()) != -1)
                {
                    if (i == letter)  // Сравниваем символ с искомым
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Буква '{0}' встречается {1} раз", letter, count);
        }
    }
}
