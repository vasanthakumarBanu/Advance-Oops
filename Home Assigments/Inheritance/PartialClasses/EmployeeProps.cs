using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses
{
    public enum Gender{slect,Male,Female,Transgender}
    public partial class EmployeeInfo
    { 
        private static int s_employeeID = 1000;
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Mobile { get; set; }

        
        
    }
}