using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateAreaAndVolume
{
    public abstract class Shape //Abstract class
    {
          //Abstract properties
        public abstract double Area {get;set;}
        public abstract double Volume {get;set;}
        //Normal properties
        public double Radius{get;set;}
        public double Height {get;set;}
        public double Side {get;set;}

        public abstract double CalculateArea();
        public abstract double CalculateVolume();       

    }
}