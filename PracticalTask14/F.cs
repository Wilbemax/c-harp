using System;


partial class Program
{
    static void F()
    {
        Random random = new Random();
        int arraySize = random.Next(10, 50);
        int[] array = new int[arraySize];
        Console.Write("Массив: ");
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = random.Next(1, 101);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        int sum = 0;
        for (int i = 0; i < array.Length - 1; i += 2)
        {
            sum += array[i];
        }
        Console.WriteLine("Ср.а. =  {0}", sum / (array.Length / 2));

    }
}
