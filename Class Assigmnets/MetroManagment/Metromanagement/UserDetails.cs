using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Metromanagement
{
    public class UserDetails:PersonelDetails,IBalance
    {//Field
        private static int s_cardNumber = 1000;
        private  double _balance;
        public string CardNumber {get;set;}
        public double WalletBalance {get{return _balance;}}

        ////Parametrized constructor
        public UserDetails(string name,string phoneNumber,double WalletBalance):base(name,phoneNumber)
        {
            ++s_cardNumber;
            CardNumber = "CMRL"+s_cardNumber;
            _balance = WalletBalance;
        }
         public UserDetails(string cardNumber,string name,string phoneNumber,double WalletBalance):base(name,phoneNumber)
        {
            CardNumber = cardNumber;
            _balance = WalletBalance;
        }
       //user details for file handling
        public UserDetails(string user)
        {
            string [] values = user.Split(",");

            CardNumber = values[0];
            s_cardNumber = int.Parse(values[0].Remove(0,4));
            Name = values[1];
            PhoneNumber = values[2];
            _balance = double.Parse(values[3]);
        }

       

    
    //wallet recharge method
        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }
        //decut balance method
        public void deductbalance(double amount)
        {
            _balance -= amount;
        }
      
        
    }
}