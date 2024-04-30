using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace GroceryStore
{
    
    public class ProductDetails
    {
        
        private static int s_productID = 2000;
        public string ProductID { get; }
        public string ProductName { get; set; }
        public int QuantityAvialable { get; set; }
        public int PricePerQuantity { get; set; }


        public ProductDetails(string productName, int quantityAvialable, int pricePerQuantity)
        {
            ++s_productID;
            ProductID = "PID" + s_productID;
            ProductName = productName;
            QuantityAvialable = quantityAvialable;
            PricePerQuantity = pricePerQuantity;
        }

        public static void ShowProductDetails()
        {
            System.Console.WriteLine("|ProductID|Product Name|Quantity Avialable|Priceperquantity|");
            foreach (ProductDetails products in Operations.productList)
            {
                System.Console.WriteLine($"|{products.ProductID}|{products.ProductName}|{products.QuantityAvialable}|{products.PricePerQuantity}");
            }
        }
    }
}