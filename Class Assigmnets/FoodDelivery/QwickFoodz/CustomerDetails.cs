using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class CustomerDetails:PersonelDetails,IBalance
    {
        
        //field
        public double _balance;
        //Property
        private static int s_customerID = 1000;
        public string CustomerID {get;}
        //property interdafce from balance
        public double WalletBalance { get{return _balance;} } 
        //COnstructor and add Personle details inheritance
       public CustomerDetails(string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID,string location,double walletBalance):base(name,fatherName,gender,mobile,dob,mailID,location)
       {
        ++s_customerID;
        CustomerID = "CID"+s_customerID;
        _balance = walletBalance;

       }
    //    public CustomerDetails(string CustomerID,string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID,string location,double walletBalance):base(name,fatherName,gender,mobile,dob,mailID,location)
    //    {
    //     string [] values = 
    //     CustomerID = 
    //     // ++s_customerID;
    //     CustomerID = "CID"+s_customerID;
    //     _balance = walletBalance;

    //    }
       //Methods interdafce from balance
       public  void WalletRecharge(double amount)
       {
        if(amount > 0)
        {
             _balance += amount;
        }
        else
        {
            System.Console.WriteLine("Enter the valid amount");
        }
       

       }
       public void  DeductBalance(double amount)
       {
        _balance -= amount;

       }
          
   
   
    }

}