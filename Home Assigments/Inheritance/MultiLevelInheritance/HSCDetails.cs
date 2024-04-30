using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class HSCDetails:StudentInfo
    {
        private static int s_hscMarksheetNumber = 1000;
        public string HSCMarkSheetNumber { get; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double PercentageMarks { get; set; }
    
    public HSCDetails(string registerNumber, string name,string fatherName,string phone,string mailID,DateTime dob,Gender gender,int standard,string branch,DateTime academicYear,int hscMarkSheetNumber,int physics,int chemistry,int maths,int total,double percentageMarks):base(registerNumber,name,fatherName,phone,mailID,dob,gender,standard,branch,academicYear)
    {
        ++s_hscMarksheetNumber;

        HSCMarkSheetNumber = "HSC"+ s_hscMarksheetNumber;
        Physics = physics;
        Chemistry = chemistry;
        Maths = maths;
        Total = total;
        PercentageMarks = percentageMarks;
    }
        public HSCDetails(string hSCMarkSheetNumber,string registerNumber, string name,string fatherName,string phone,string mailID,DateTime dob,Gender gender,int standard,string branch,DateTime academicYear,int hscMarkSheetNumber,int physics,int chemistry,int maths,int total,double percentageMarks):base(registerNumber,name,fatherName,phone,mailID,dob,gender,standard,branch,academicYear)
    {
        HSCMarkSheetNumber = hSCMarkSheetNumber;
        Physics = physics;
        Chemistry = chemistry;
        Maths = maths;
        Total = total; 
        PercentageMarks = percentageMarks;
    }
    public static void GetMakrs()
    {

    }
     public static void Calculate()
    {
        
    }
     public static void ShowMarkSheet()
    {
        
    }

    }

}