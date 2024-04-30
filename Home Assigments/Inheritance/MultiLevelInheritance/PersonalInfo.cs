using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{ public enum Gender {Select,Male,Female}
    public class PersonalInfo
    {
        public string Name {get;set;}
        public string FatherName { get; set; }
        
        public string Phone { get; set; }
        public string MailID  { get; set; } 
        public DateTime DOB { get; set; }
        public Gender Gender {get;set;}

        public PersonalInfo(string name,string fatherName,string phone,string mailID,DateTime dob,Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            MailID= mailID;
            DOB = dob;
            Gender = gender;
        }
    }
}