using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{ public enum Gender{Select,Male,Female,Transgender}
    public class PersonelDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string MailID { get; set; }

        public PersonelDetails(string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dob;
            MailID = mailID;

        }
    }
}