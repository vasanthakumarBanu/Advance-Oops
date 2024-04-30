
using System;
namespace OperatorOverloading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1 = new Box (1.2,3.2,4.2);
        Box box2 = new Box (2.2,1.2,2.2);
        System.Console.WriteLine(box1.ClaculateVolume());
        System.Console.WriteLine(box2.ClaculateVolume());

        Box box3 = Box.Add(box1,box2);
        Box box4 = box1+box2;



    }
}