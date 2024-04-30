using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public class OderDetails
    {
        private static int s_oderID = 4000;
        public string OderID {get;set;}
        public string BookingID {get;set;}
        public string ProductID {get;set;}
        public int PurchaseCount {get;set;}
        public double PriceOfOder {get;set;}

        public OderDetails(string bookingID,string productID,int purchaseCount,double priceOfOder)
        {
            ++s_oderID;
            OderID = "OID"+s_oderID;
            BookingID = bookingID;
            ProductID = productID;
            PurchaseCount = purchaseCount;
            PriceOfOder = priceOfOder;
                       
        }
            

            
    
    
    }
}