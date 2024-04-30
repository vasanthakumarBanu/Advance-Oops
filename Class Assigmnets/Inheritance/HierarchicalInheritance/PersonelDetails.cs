using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
     public enum Gender { Male,Female,Transgender}
    public class PersonelDetails
    {
       
        private static int s_userID=1000;

        public string UserID {get;}
        public string Name {get;set;}
        public string FatherName {get;set;}
        public Gender Gender {get;set;}
        public string PhoneNumber {get;set;}

        public PersonelDetails(string name,string fatherName,Gender gender,string phoneNumber)
        {
            s_userID++;

            UserID = "PD"+s_userID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            PhoneNumber = phoneNumber;

        }
        public PersonelDetails(string userID,string name,string fatherName,Gender gender,string phoneNumber)
        {
            

            UserID = userID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            PhoneNumber = phoneNumber;
 
        }
        
        
    }
}