using System;
using ClassLibrary;
// dotnet new slndotnet sln add ConsoleApp2/ConsoleApp2.csproj
// dotnet sln add ConsoleApp2/ConsoleApp2.csproj
// dotnet sln add ClassLibrary/ClassLibrary.csproj
// dotnet add reference ../ClassLibrary/ClassLibrary.csproj

partial class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine(Helper.Add(10,20));
       int[] array = Helper.Init();
       Helper.Print(array);
       Console.WriteLine(Helper.Min(array));
       Helper.Sort(array);
        Helper.Print(array);
    }
}
