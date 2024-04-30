using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public class CustomerRegistration : PersonelDetails, IBalance
    {
        private static int s_customerID = 1000;
        private double _balance;
        public string CustomerID {get;set;}
        public double WalletBalance{get{return _balance;}}


        public CustomerRegistration(double WalletBalance,string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID):base(name,fatherName,gender,mobile,dob,mailID)
        {
            ++s_customerID;
            CustomerID = "CID"+ s_customerID;
        }        
        

        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }
        public void deductbalance(double amount)
        {
            _balance -= amount;
        }


    }

}