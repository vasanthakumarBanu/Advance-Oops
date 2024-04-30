using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SingleInheritance;

namespace MultiLevelInheritance
{
    public class EmployeeDetails:StudentDetails
    {
        private static int s_employeeID = 1000;
        public string EmployeeID {get;set;}
        public string Designation {get;set;}

        public EmployeeDetails (string designation, string studentID,string name,string fatherName,Gender gender,string phoneNumber,int standard,string yearofJoining):base(studentID,name,fatherName,gender,phoneNumber,standard,yearofJoining)
        {
            s_employeeID++;
            EmployeeID ="EMP"+ s_employeeID;
            Designation = designation;


        }
            public EmployeeDetails (string employeeID,string designation, string studentID,string name,string fatherName,Gender gender,string phoneNumber,int standard,string yearofJoining):base(studentID,name,fatherName,gender,phoneNumber,standard,yearofJoining)
        {
            
            EmployeeID =  employeeID;
            Designation = designation;


        }
    }
}