using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Circle2:ICalculate
    {
        private int _number2 {get;set;}
        public int Number { get {return _number2;} set{_number2 = value;}}
       

        public int Calculate()
        {
            _number2 = (int)(Math.PI*Math.Pow(_number2,_number2));
            return _number2;
        }
    }
}