using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class UserDetails:PersonalDetails,IWallet
    {

            private static int s_UserID = 1000;
            public static double _balance;
            public string UserID { get; set; }
            public double WalletBalance{get{return _balance;}}

            public UserDetails(string name,int age,string city, string phone,double walletBalance):base(name,age,city,phone)
            {
                ++s_UserID;
                UserID = "UID"+ s_UserID;
                _balance = walletBalance;
            }
            public void WalletRecharge(double amount)
            {
                _balance += amount;
            }

            public void DeductBalance(double amount)
            {
                _balance -= amount;
            }

    }
}