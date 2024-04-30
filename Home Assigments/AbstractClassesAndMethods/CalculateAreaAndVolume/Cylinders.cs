using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateAreaAndVolume
{
    public class Cylinders:Shape
    {
        public override double Area {get;set;}
        public override double Volume {get;set;}
        public override double CalculateArea()
        {
            System.Console.WriteLine("Enter the Radius:");
            Radius =double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Height:");
            Height =double.Parse(Console.ReadLine());
            Area = 2*3.14*(Radius*Radius)*Height;
            return Area;
            
        }

        public override double CalculateVolume()
        {
            System.Console.WriteLine("Enter the Radius:");
            Radius =double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Height:");
             Height =double.Parse(Console.ReadLine());

             Volume = 3.14*Radius*Radius*Height;
             return Volume;
        }
    }
}