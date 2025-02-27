using System;


partial class Program
{
    static void G()
    {
        Console.Write("Введите x(целое число):");
        int x = int.Parse(Console.ReadLine());
        Random random = new Random();
        int matrixSize = random.Next(3, 11);
        int[,] matrix = new int[matrixSize, matrixSize];
        Console.WriteLine("Массив: ");
        for (int i = 0; i < matrixSize; i++)
        {
           for (int j = 0; j < matrixSize; j++)
           {
                matrix[i, j] = random.Next(1, 101);
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                if (( i + j ) % 2 == 0 && matrix[i,j] < x ){
                    matrix[i, j] = 0;
                }
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();

        }

    }
}
