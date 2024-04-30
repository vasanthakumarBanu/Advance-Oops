using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q1
{
    
    public class HSCDetails:StudentInfo
    { 
        public  double HSCMarksheetNumber {get;set;}
        public double Physics {get;set;}
        public double Chemistry {get;set;}
        public double Maths {get;set;}
        public double Total {get ; set;}
        public double PercentageMarks {get; set;}


        public  HSCDetails (string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,int standard,string branch,DateTime academicYear,double hscMarksheetNumber,double physics,double chemistry,double maths,double total,double percentageMarks):base(name,fatherName,phone,mail,dob,gender,standard, branch,academicYear)
        {
            HSCMarksheetNumber = hscMarksheetNumber;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
            Total = total;
            PercentageMarks = percentageMarks;
        }
        public void GetMarks()
        {
              System.Console.WriteLine("ENter your Physics mark");
              double physics =double.Parse(Console.ReadLine());
              System.Console.WriteLine("ENter your Chemisty mark");
              double chemistry =double.Parse(Console.ReadLine());
              System.Console.WriteLine("ENter your Maths mark");
              double maths =double.Parse(Console.ReadLine());
        }
         public void Calculate()
        {
            double total = Physics+Chemistry+Maths;
            System.Console.WriteLine(Total);
            double PercentageMarks = total/3;
            System.Console.WriteLine($"{Total}%");

        }
         public void ShowMarkSheet()
        {
            
        }

    }
}