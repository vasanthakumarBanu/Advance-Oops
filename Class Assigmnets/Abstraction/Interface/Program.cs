using System;
using System.Data;
namespace Interface;
class Program
{

    public static void Main(string[] args)
    {
        Square number = new Square();// class variable as object
        number.Number = 20;
        Console.WriteLine(number.Calculate());

        Circle2 number2 =  new Circle2();
        number2.Number = 2;
        Console.WriteLine(number2.Calculate());


    }
}