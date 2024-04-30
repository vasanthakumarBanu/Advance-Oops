using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class CustomerDetails:PersonelDetails 
    {
        private static int s_customerID = 1000;
        public string CutomerID {get;}
        public int Balance{get;set;}

        public CustomerDetails(int balance,string userID,string name,string fatherName,Gender gender,string phoneNumber):base(userID,name,fatherName,gender,phoneNumber)
        {
            s_customerID++;
            CutomerID = "CID"+s_customerID;
            Balance = balance;

        }
         public CustomerDetails(string customerID,int balance,string userID,string name,string fatherName,Gender gender,string phoneNumber):base(userID,name,fatherName,gender,phoneNumber)
        {
           
            CutomerID = customerID;
            Balance = balance;

        }

        
    }
}