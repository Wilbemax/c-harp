using System;

class Hallo
{
    static void Main()
    {
//---------------------------------------1
    // int firstDigit;
    // int secondDigit;
    // int swapDigit;
    // Console.Write("Введите первое число диопазона: ");
    // firstDigit =  int.Parse(Console.ReadLine());
    

    // Console.Write("Введите вотрое число диопазона: ");
    // secondDigit =  int.Parse(Console.ReadLine());
    
    // if (firstDigit >  secondDigit) {
    //     swapDigit = firstDigit;
    //     firstDigit = secondDigit;
    //     secondDigit = swapDigit;
    //     Console.WriteLine("Была произведенна замена чисел, так как первое число диопазона больше второго");
    // } else if ( firstDigit == secondDigit){
    //     Console.WriteLine("Диопазон не определен");
    //      return;
    // } 

    //     for (int i = firstDigit; i <= secondDigit; i++)
    //     {
    //         if ( i % 5 != 0){
    //             Console.Write("{0}, ", i);
    //         }
    //     }
    

    //---------------------------------------------------2


    // int numbersAmount = 5;
    

    // for (int i = 1; i <= numbersAmount; i++)
    // {
    //     for (int j = i; j > 0; j--)
    //     {
    //         Console.Write("{0} ",j);
    //     }
    //     Console.WriteLine();
    // }
    


    //-----------------------------------3
    // 5 задание 

    int numA;
    int numB;
    double numH;
    int iteration = 0;

    Console.Write("Введите A: ");
    numA = int.Parse(Console.ReadLine());
    
    Console.Write("Введите B: ");
    numB = int.Parse(Console.ReadLine());

    Console.Write("Введите шаг (h): ");
    numH = double.Parse(Console.ReadLine());
    
    
    Console.WriteLine("{0,3} {1,5} {2,5}", "#", "x", "f(x)");
    
    for (double i = numA; i <= numB; i += numH)
    {
        iteration++;
        double exceptions = Math.Pow(i, 2) - 5 * i;
        if (exceptions < 0){
            Console.WriteLine("{0,3} {1,5:f2} {2,5:f2} ",iteration, i, i + numB);
        }
        if (exceptions >= 0 && exceptions  < 10 ){
             Console.WriteLine("{0,3} {1,5:f2} {2,5:f2} ",iteration, i,i - numB);
        }
        if (exceptions >= 10) {
             Console.WriteLine("{0,3} {1,5:f2} {2,5:f2} ",iteration, i,i*numB);
        }

    }

    

}
}