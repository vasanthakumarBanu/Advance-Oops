using System;
using System.Buffers;
using System.Linq.Expressions;
using MathsLib;
namespace CalculatorApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cylinder cylinder  = new Cylinder(20,30,30);
            cylinder.CalculateVolume(20,30);
        }
    }
}