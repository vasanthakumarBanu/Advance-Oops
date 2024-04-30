using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagment
{

    public class UserDetails : PersonalDetails, IBalance
    {
        private double _balance;
        private static int s_userID = 1000;
        public string UserID { get;set;}
        public string WorkStationNumber { get; set; }
        public double WalletBalance { get { return _balance; } }

        public UserDetails(string name, string fatherName, Gender gender, long mobileNumber, string mailID, int _balance, string workStationNumber) : base(name, fatherName, gender, mobileNumber, mailID)
        {

            ++s_userID;
            UserID ="SF"+s_userID;
            WorkStationNumber = workStationNumber;

        }
        public UserDetails(string userID,string name, string fatherName, Gender gender, long mobileNumber, string mailID, int _balance, string workStationNumber) : base(name, fatherName, gender, mobileNumber, mailID)
        {

            ++s_userID;
            UserID = userID;
            WorkStationNumber = workStationNumber;

        }

        public void WalletRecharge(double amount)
        {
            _balance += amount;
            
        }
        public void DeductAmount(double amount)
        {
           _balance -= amount;
        }




    }
}
