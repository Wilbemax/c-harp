using System;
using System.IO;
using System.Text;


class Program
{

    static void Task1()
    {
        string newFilePath = @"D:\c-harp\PracticalTask10\Text.txt";
        var fileInfo = new FileInfo(newFilePath);
        fileInfo.Create().Close();
    }

    static void Task2()
    {
        string newFilePath = @"D:\c-harp\PracticalTask10\Text.txt";
        var fileInfo = new FileInfo(newFilePath);
        if (fileInfo.Exists)
        {
            Console.WriteLine("Путь к файлу: {0}", fileInfo.DirectoryName);
            Console.WriteLine("Имя файла: {0}", fileInfo.Name);
            Console.WriteLine("Время создания: {0}", fileInfo.CreationTime);
            Console.WriteLine("Размер: {0} байт", fileInfo.Length);
        }
    }

    static void Task3()
    {
        string newFilePath = @"D:\c-harp\PracticalTask10\Text.txt";
        var fileInfo = new FileInfo(newFilePath);
        if (!fileInfo.Exists)
        {
            Console.WriteLine("Файл не существует. Создайте файл с помощью Task1.");
            return;
        }

        using (StreamWriter sw = new StreamWriter(newFilePath))
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = random.Next(0, 100);
                sw.WriteLine(num);
            }
        }
    }

    static void Task4()
    {
        string filePath = @"D:\c-harp\PracticalTask10\Text.txt";
        string newFilePath = @"D:\c-harp\PracticalTask10\NewText.txt";
        var fileInfo = new FileInfo(filePath);
        if (fileInfo.Exists)
        {
            fileInfo.CopyTo(newFilePath, true);

        }
    }


    static void Task5()
    {
        string filePath = @"D:\c-harp\PracticalTask10\Text.txt";
        var fileInfo = new FileInfo(filePath);
        if (fileInfo.Exists)
        {
            fileInfo.Delete();
        }
    }



    static void Main()
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        Task5();
    }
}