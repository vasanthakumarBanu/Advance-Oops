using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea:Maths
    {
       private double  _radius ;
       public double Radius {get;}
       internal int area {get; set;}


        public CircleArea(double radius,double mass):base(mass)
        {
            Radius = radius;
        }
       public double CalculationCircleArea(double radius)
       {
            return PI*radius*radius;
            
       }

        
    }
}