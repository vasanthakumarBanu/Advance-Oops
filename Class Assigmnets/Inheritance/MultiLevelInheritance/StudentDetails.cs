using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class StudentDetails:PersonelDetails
    {
        private static int s_studentID = 5000;
        public string StudentID {get;}
        public int Standard{get;set;}

        public string YearofJoining {get;set;}
        
        public StudentDetails ( string name,string fatherName,Gender gender,string phoneNumber,int standard,string yearofJoining):base(name,fatherName,gender,phoneNumber)
        {
            s_studentID++;
            StudentID = "SJC"+s_studentID;
            Standard = standard;
            YearofJoining = yearofJoining;
            Name = name;

        }
           public StudentDetails ( string studentID,string name,string fatherName,Gender gender,string phoneNumber,int standard,string yearofJoining):base(name,fatherName,gender,phoneNumber)
        {
            StudentID =studentID;
            Standard = standard;
            YearofJoining = yearofJoining;
            Name = name;

        }
    }
}