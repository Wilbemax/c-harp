using System;

namespace TestProject
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }

        static int f(int x)
        {
            int min = 9;

            do
            {
                if (x % 10 < min) min = x % 10;
                x /= 10;
            }
            while (x > 0);

            return min;
        }

        static double Hypotenuse(int x, int y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        static void Main(string[] args)
        {
            int x = 2, y = 5, c = 10;

            Swap(ref x, ref y);
            Console.WriteLine("После Swap:");
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);

            int z;
            z = Min(3 * x, 2 * y) + Min(x - y, x + y);
            Console.WriteLine("z = {0}", z);

            int resultF;
            resultF = f(x) + f(y) + f(c);
            Console.WriteLine("f = {0}", resultF);


            int ab = 10, ac = 11, dc = 5;
            double db = Hypotenuse(Convert.ToInt32(Hypotenuse(ab, ac), dc));
            Console.WriteLine("Гипотенуза: {0}", db);

            Console.WriteLine("Периметр: {0}", ab + ac + dc + db);

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey(true);
        }
    }
}