using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class ItemDetails
    {//ItemID – (ITID100), OrderID, FoodID, PurchaseCount, PriceOfOrder
        //Field
        private static int s_itemID = 4000;
        //Property
        public string ItemID {get;set;}

        public string OderID {get;set;}
        public string FoodID {get;set;}
        public int PurchaseCount { get; set; }
        public double PriceOfOrder {get;set;}
        //Constructor
        public ItemDetails(string oderID, string foodID ,int purchaseCount,double priceOfOrder)
        {
            ++s_itemID;
            ItemID = "ITI"+ s_itemID;
            OderID = oderID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }        
    }
}