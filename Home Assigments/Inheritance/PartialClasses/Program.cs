using System;
using System.Collections.Generic;
using PartialClasses;
class Program
{
    public static void Main(string[] args)
    {
        List<EmployeeInfo> employeeList = new List<EmployeeInfo>();
        EmployeeInfo employee = new EmployeeInfo("Vasanthakumar",Gender.Male,new DateTime(1997,07,18),"8110877339");
        employeeList.Add(employee);
        EmployeeInfo.Update();
        EmployeeInfo.Display();
        
    }
}
