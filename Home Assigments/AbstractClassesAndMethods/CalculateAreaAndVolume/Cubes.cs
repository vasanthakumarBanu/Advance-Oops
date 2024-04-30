using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateAreaAndVolume
{
    public class Cubes:Shape
    {   
        public override double Area{get;set;}
        public override double Volume {get;set;}
        public override double CalculateArea( )
        {  System.Console.WriteLine("Enter Area of one Side");
           Side =double.Parse(Console.ReadLine());
            Area = 6*(Side*Side);
            return Area;
        }
        public override double CalculateVolume()
        {
            System.Console.WriteLine("Enter Area of one Side");
             Area =double.Parse(Console.ReadLine());
            Volume = Area*Area*Area;
            return Volume;
        }    
    
    }
}