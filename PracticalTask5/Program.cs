using System;

class Hallo
{
    static int Sum(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 7 == 0)
            {
                count += array[i];
            }
        }
        return count;
    }

    static int TakeSum(int[] array, int index1, int index2){
        int sum = 0;
        for (int i = index1; i <= index2 ; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static void Main()
    {
        //---------------------------1
        // Random random = new Random();
        // int[] array;
        // int n = random.Next(10, 100);
        // int sumInt;
        // array = new int[n];

        // for (int i = 0; i < n; i++)
        // {
        //     array[i] = random.Next(2140000000);
        // }

        // sumInt = Sum(array);
        // Console.WriteLine("Сумма чисел массива кратных 7: {0}", sumInt);


        //-----------------------------2
        Console.Write("Введите количество элементов в массиве: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        int maxIndex = 0;
        int minIndex = 0;
        int sumArray = 0;

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex]) {
                maxIndex = i;
            } else if (array[i] < array[minIndex]){
                minIndex = i;
            }
        }

        if (maxIndex < minIndex || maxIndex == minIndex) {
            Console.WriteLine("Элементы равны или максимальное значение раньше минимального");
        } else{
            sumArray = TakeSum(array, minIndex, maxIndex);
        }

        Console.WriteLine("Сумма между минмальным и максимальным ровна: {0}", sumArray);

    }
}