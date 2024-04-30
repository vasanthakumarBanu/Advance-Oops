using System;
namespace ByArgument;
class Program
{
    public static void Main(string[] args)
    {
        Add(1,2);
        Add(1,2,3);
    }
    public static void Add(int A,int B,int C)
    {
        System.Console.WriteLine(A+B+C);
    }
    public static void Add(int A,int B)
    {
        System.Console.WriteLine(A+B);
    }
}
