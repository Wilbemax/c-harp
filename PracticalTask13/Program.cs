using System;

namespace TestProject
{


    class Program
    {

        static int task2(int b1, int b2)
        {
            return Math.Abs(b1) - 6 * b2;
        }

        static int calculateNth(int n)
        {
            if (n == 1) return -10;
            if (n == 2) return 2;

            return task2(calculateNth( n - 2), calculateNth(n - 1));
         }

        static int fib(int n)
        {
            return n <= 1 ? n : fib(n - 1) + fib(n - 2);
        }
        static void Main(string[] args)
        {
            // int fibonacciN = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= fibonacciN; i++)
            // {
            //     Console.WriteLine(fib(i) + "");
            // }
            int a = -10;
            int b = 2;
            int task2N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= task2N; i++)
            {

                // int c = task2(a, b);
                // a = b;
                // b = c;
                // Console.WriteLine(c + "");
                Console.WriteLine(calculateNth(i));
            }
        }
    }
}