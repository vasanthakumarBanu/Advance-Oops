using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class StudentInfo: PersonalInfo
    { private static int s_registerNumber = 1000;
        public string RegisterNumber { get;}
        public int Standard {get;set;}
        public string Branch {get; set;}
        public DateTime AcademicYear {get;set;}

        public StudentInfo( string name,string fatherName,string phone,string mailID,DateTime dob,Gender gender,int standard,string branch,DateTime academicYear):base(name,fatherName,phone,mailID,dob,gender)
        { 
            ++s_registerNumber;
            RegisterNumber = "SJC"+ s_registerNumber;
            Standard = standard;
            Branch =  branch;
            AcademicYear = academicYear;
        }
        public StudentInfo( string registerNumber, string name,string fatherName,string phone,string mailID,DateTime dob,Gender gender,int standard,string branch,DateTime academicYear):base(name,fatherName,phone,mailID,dob,gender)
        { 
            
            RegisterNumber = registerNumber;
            Standard = standard;
            Branch =  branch;
            AcademicYear = academicYear;
        }
        public static void GetStudentInfo()
        {
            
        }
        public  static void ShowInfo()
        {
            System.Console.WriteLine($"{Student1}");
           
        }
    
    }
}