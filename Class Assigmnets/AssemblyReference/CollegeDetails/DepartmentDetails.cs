using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeDetails
{  
    public class DepartmentDetails
    { 
        /*a.	DepartmentID – (AutoIncrement - DID101)
            b.	DepartmentName
            c.	NumberOfSeats*/

            private static int s_departmentID = 100;
            public string DepartmentID {get;}
            public string DepartmentName {get;set;}
            public int NumberOfSeats {get;set;}
            
            
            
            public DepartmentDetails(string departmentName, int numberOfSeats)
            {    s_departmentID++;
                DepartmentID = "DID"+s_departmentID;
                DepartmentName = departmentName;
                NumberOfSeats = numberOfSeats;
            }

    }
    
}