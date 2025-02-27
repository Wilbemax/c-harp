using System;


partial class Program
{
    static void B(int num)
    {
       switch (num)
       {
        case 1:
            C();
            break;
        case 2:
            D();
            break;
        case 3:
            E();
            break;
        case 4:
            F();
            break;
        case 5:
            G();
            break;
        default:
            Console.WriteLine("Такого задания нет");
            break;
       }
    }
}
