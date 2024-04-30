using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    public class PersonelDetailsC:PersonelDetailsB
    {
        public int CalculateAge()
         {
            TimeSpan span = DateTime.Now - DOB;
            int age = span.Days/365;
            return age;
        }
    }
}