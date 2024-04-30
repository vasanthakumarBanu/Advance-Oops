using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleinHeritance
{
    public class StudentInfo:PersonelInfo
    {
        private static int s_registerNumber = 1000;
        public string RegisterNumber{get;set;}
        public int Standard{get;set;}
        public string Branch {get;set;}
        public string AcademicYear {get;set;}

        public StudentInfo(string name,string fatherName,string phoneNumber,DateTime dob,Gender gender,int standard,string branch,string academicYear):base(name,fatherName,phoneNumber,dob,gender)
    
        {
            ++s_registerNumber;
            RegisterNumber = "SJC"+s_registerNumber;
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;

        }

    }
}