using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleinHeritance
{ public enum Gender {select,Male,Female}
    public class PersonelInfo
    {
        public string Name {get;set;}
        public string FatherName {get;set;}
        public string PhoneNumber {get;set;}
        public string MailID {get;set;}
        public DateTime DOB {get;set;}
        public Gender Gender {get;set;}

        public PersonelInfo(string name,string fatherName,string phoneNumber,DateTime dob,Gender gender)

        {
            Name = name;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            DOB = dob;
            Gender = gender;
        }
        
    }
}