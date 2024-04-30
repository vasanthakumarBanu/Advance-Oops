using System;
using CalculateAreaAndVolume;
class Program
{
    public static void Main(string[] args)
    {
        Shape cylinder = new Cylinders();
        System.Console.WriteLine($"Surface Area of the Cylinder is {cylinder.CalculateArea()}");
         System.Console.WriteLine($"Volume of the Cylinder is {cylinder.CalculateVolume()}");

         Shape cube = new Cubes();
         System.Console.WriteLine($"Surface Area of the Cube is {cube.CalculateArea()}");
         System.Console.WriteLine($"Volume of the Cube is {cube.CalculateVolume()}");
         System.Console.WriteLine("Thank you");

    }
}