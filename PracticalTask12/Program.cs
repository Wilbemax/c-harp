using System;

namespace TestProject
{
    class Program
    {

        static double getLen(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static double max(double a, double b)
        {
            return a > b ? a : b;
        }


        static int numSum(int n)
        {
            if (n < 10) return n;

            string numString = n.ToString();
            int sum = 0;
            for (int i = 0; i < numString.Length; i++)
            {
                sum += int.Parse(numString[i].ToString());
            }
            return sum;
        }
        static bool isSimple(int n)
        {

            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            double limit = Math.Sqrt(n);
            for (int i = 3; i <= limit; i ++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
        static double average(int a, int b)
        {
            double avg = (a + b) / 2.0;
            return avg;
        }
        static void Main(string[] args)
        {

            int a = 1, b = 100, c = 13;
            double res = average(17, 44);
            Console.WriteLine(res);


            for (int i = a; i < b; i++)
            {
                if (isSimple(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = a; i < b; i++)
            {
                if (!isSimple(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);

            for (int i = a; i < b; i++)
            {
                if (numSum(i) == c)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();


            for (int i = a; i < b; i++)
            {
                if (numSum(i) % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();


            double x1 = 3, y1 = 4;
            double x2 = -2, y2 = 7;
            double x3 = 5, y3 = -1;

            double dist1 = getLen(0, 0, x1, y1);
            double dist2 = getLen(0, 0, x2, y2);
            double dist3 = getLen(0, 0, x3, y3);

            double maxDist = max(max(dist1, dist2), dist3);

            if (maxDist == dist1)
            {
                Console.WriteLine("Точка 1 наиболее удалена от начала координат.");
            }
            else if (maxDist == dist2)
            {
                Console.WriteLine("Точка 2 наиболее удалена от начала координат.");
            }
            else
            {
                Console.WriteLine("Точка 3 наиболее удалена от начала координат.");
            }


            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey(true);
        }


    }
}