using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q1
{
    public class StudentInfo:Personelinfo
    {
        private static int s_registerNumber = 1000;
        public string RegisterNumber {get;}
        public int Standard { get; set; }
        public string Branch { get; set; }
        public DateTime AcademicYear { get; set; }

        public StudentInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,int standard,string branch,DateTime academicYear):base(name,fatherName,phone,mail,dob,gender)
        {
            ++s_registerNumber;
            RegisterNumber = "SJC"+s_registerNumber;
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;

        }
        public void GetStudentInfo()
        {
            

        }
         public void ShowStudentInfo()
        {
            
        }
        
    }
}