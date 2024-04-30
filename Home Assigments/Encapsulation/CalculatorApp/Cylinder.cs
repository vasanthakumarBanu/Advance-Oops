using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Cylinder:CircleArea
    {
        private double height;
        public double Height {get;set;}
        internal double volume {get;set;}


            public Cylinder(double heigth,double mass,double radius):base(radius,mass)
            {
                Height = height;
            }
        public double 
        (double Radius,double heigth)
        {
            return CalculationCircleArea(Radius)*height;
        }

        
    }
}