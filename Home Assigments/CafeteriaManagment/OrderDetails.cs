using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagment
{
    public enum OderStatus { Default, Initiated, Odered, Cancelled }
    public class OrderDetails
    {
        private static int s_oderID = 1000;
        public string OderID { get; }
        public string UserID {get;set;}
        public DateTime OderDate { get; set; }
        public double TotalPrice { get; set; }
        public OderStatus OderStatus { get; set; }

        public OrderDetails(string userID,DateTime oderDate, double totalPrice,OderStatus oderStatus)
        {   ++ s_oderID;
            OderID = "IOD" + s_oderID;
            UserID = userID;
            OderDate = oderDate;
            TotalPrice = totalPrice;
            OderStatus = oderStatus;
        }

    }
}