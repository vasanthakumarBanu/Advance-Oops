using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagment
{
    public class Cartltem
    {
        private static int s_itemID = 100;
        public string ItemID;
        public string OderID {get;set;}
        public string FoodID { get; set; }
        public double OderPrice { get; set; }
        public int OderQuantity { get; set; }
        public Cartltem(string oderID,string  foodID,double oderPrice,int oderQuantity) 
        {
            ++s_itemID;
            ItemID = "ITID"+s_itemID;
            OderID = oderID;
            FoodID = foodID;
            OderPrice = oderPrice;
            OderQuantity = oderQuantity;
        }
        
        
    }
}