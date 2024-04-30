using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{ public enum OderStatus {Default, Initiated, Ordered, Cancelled}
    public class OderDetails
    {//OrderID, CustomerID, TotalPrice, DateOfOrder, OrderStatus – {Default, Initiated, Ordered, Cancelled}.
        //Field
        private static int s_oderID = 3000;
        //Property
        public string OderID { get; }
        public string CustomerID {get;set;}
        public double TotalPrice {get; set; }
        public DateTime DateOfOder {get;set;}
        public OderStatus OderStatus {get;set;}
        //constructor
        public OderDetails(string customerID,double totalPrice,DateTime dateOfOder,OderStatus oderStatus)
        {
            ++s_oderID;
            OderID = "OID"+s_oderID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfOder = dateOfOder;
            OderStatus = oderStatus;

        }

    }
}