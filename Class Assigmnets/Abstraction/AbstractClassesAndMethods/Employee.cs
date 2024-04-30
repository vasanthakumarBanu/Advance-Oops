using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public abstract class Employee //Abstract Class
    {

        //Abstract class - partial abstraction.
        //INside class ---It has fields, property, metod, constructor, destructor, indexers, events.
        //Can have both abstract declartion and normal definition.
        //Can only used with an inhherited class
        //Not support multiple inheritance
        //it cannot be static class
        protected string _name;//normal fields 1

        public abstract string Name { get; set; }//Abstract Property 2

        public double Amount { get; set; }//Normal Property 4
        public string Display()//Normal Method 5 
        {
            return _name;
        }
        public abstract double Salary(int dates);//Abstract Method -Only Declaration 6 
    }
}