using System;

namespace Inside;
class Program
{
    public static void Main(string[] args)
    {
        First sample = new First();
        Second sample1 = new Second();
        System.Console.WriteLine(sample.PrivateOut);
        System.Console.WriteLine(sample.PublicNumber);
        System.Console.WriteLine(sample.ProtectedInternalOut);
    }
}