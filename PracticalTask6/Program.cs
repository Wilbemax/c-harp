using System;

class Program
{
    static void Input(out int[,] array)
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("m= ");
        int m = int.Parse(Console.ReadLine());

        array = new int[n, m];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("a[{0}, {1}] = ", i, j);
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }


    static void PrintInMatrix(int[,] array)
    {
        Console.WriteLine("Matrix view");
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }


    static void Main()
    {
        // побочная диоганаль i + j < n - 1

        int[,] array;
        Input(out array);
        // 1 (5)

        // int sum = 0;
        // int count = 0;

        // for (int i = 1; i < array.GetLength(0); i++)
        // {
        //     for (int j = 0; j < i; j++)
        //     {
        //         sum += array[i, j];
        //         count++;
        //     }
        // }

        // if (count > 0)
        // {
        //     double aver = (double)sum / count;
        //     Console.WriteLine("Среднее значение элементов ниже главной диагонали: " + aver);
        // }
        // else
        // {
        //     Console.WriteLine("Нет элементов ниже главной диагонали.");
        // }


        //2 (9)

        int[] res = new int[array.GetLength(1)];


        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Console.Write("{0} ", array[i, j]);

                if (array[i, j] % 2 != 0)
                {
                    res[j] = array[i, j];
                } 

            
            }
        }
        // Console.WriteLine();



        Console.Write("res:  ");
        for (int i = 0; i < res.Length; i++)
        {
            
            Console.Write(" {0} ", res[i]);
        }

        Console.WriteLine();

        PrintInMatrix(array);
    }
}